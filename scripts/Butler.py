import wx
import os, sys, subprocess, errno
import speech_recognition as sr
from pygoogle import pygoogle
import webbrowser
import wikipedia
import random
from bs4 import BeautifulSoup
import requests
from logging import log

class Display(wx.Frame):

    def __init__(self, parent, id):
        wx.Frame.__init__(self, parent , id, 'Butler', size=(300,200))
        panel = wx.Panel(self)
        btn = wx.Button(self, label = "Tell Butler!", pos=(100,100))
        self.Bind(wx.EVT_BUTTON, self.Tell, btn)

    def Tell(self, event):
        #TODO:change to wx.message
        #print "Butler ready!"
        
        r = sr.Recognizer()

        # with sr.WavFile("open.wav") as source:
        with sr.Microphone() as source:
            audio = r.listen(source)

        # print "Butler on duty..."
        duty = wx.MessageDialog(None, "Butler on duty!", 'Butler', wx.OK)
        duty.ShowModal()


        try:
            special = str(r.recognize(audio)).split()
            command = str(r.recognize(audio)).split(' ',1)
            targetString = command[1]
        except LookupError:
            box = wx.MessageDialog(None, "Couldn't understand", 'Butler', wx.ICON_HAND)
            box.ShowModal()


        #----------------
        # command =[1]
        # command[0] = 'run'
        # targetString = 'Calculator.app'
        #----------------

        if command[0] == 'run' or command[0] == 'open':
            #print "Running " + targetString.title() + "!"
            targetString = targetString.lower()
            os.chdir('/Applications')
            root = os.getcwd()
            appList = next(os.walk(root))[1]
            for apps in appList:
                apps = apps.lower()
                print apps
                if apps == targetString or apps[:-4] == targetString:
                    if ' ' in apps:
                        try:
                            apps = apps.split(" ")
                            subprocess.call('open ' + apps[0] + "\ " + apps[1], shell=True)
                            break
                        except Exception, e:
                            box = wx.MessageDialog(None, "The app is corrupted or does not exist", 'Butler', wx.OK)
                            box.ShowModal()
                    else:
                        try:
                            subprocess.call('open ' + apps, shell=True)
                            break
                        except Exception, e:
                            box.ShowModal()

        elif command[0] == 'Google' or command[0] == 'search':
            g = pygoogle(targetString)
            g.pages = 1
            # print '*Found %s results*'%(g.get_result_count())
            urls = g.get_urls()
            # print "*List of the URLs on the first page of the result*"
            # for url in urls:
            #   print url
            webbrowser.open("https://www.google.com/#q=" + targetString)
            webbrowser.open(urls[0])


        #TODO Optimize it
        # elif command[0] == 'open':
        #     os.chdir('/Users/josephwon')
        #     try:
        #         root = os.path.join(os.getcwd(), targetString)
        #         os.chdir(root)
        #         dirList = next(os.walk(root))[1] #returns the folders in the given directory
        #         folist = []
        #         for folders in dirList:
        #             if folders[0] != '.':
        #                 folist += folders
        #         enter = wx.TextEntryDialog(None, str(folders in folist), 'Folders', 'type in folder')
        #         target = enter.ShowModal()
        #         try:
        #             subprocess.call("open ./" + target, shell=True)
        #         except Exception, e:
        #             wrongFolder = wx.MessageDialog(None, "The file doesn not exist", 'Error', wx.ICON_HAND)
        #             wrongFolder.ShowModal()
        #     except Exception, e:
        #         wrongFolder = wx.MessageDialog(None, "The file doesn not exist", 'Error', wx.ICON_HAND)
        #         wrongFolder.ShowModal()

        # elif command[0] == 'create' or command[0] == 'touch':
        #     os.chdir('/Users/josephwon/Desktop')
        #     try:
        #         os.makedirs(targetString)
        #         print targetString + " created!"
        #     except OSError as exc:
        #         if exc.errno == errno.EEXIST and os.path.isdir(targetString):
        #             #Optimize it!
        #             exie = wx.MessageDialog(None, "The file already exists", 'Error', wx.ICON_HAND)
        #             exie.ShowModal()
        #             pass
        #         else:
        #             raise

        elif command[0] == 'delete' or command[0] == 'remove' or command[0] == 'erase':
            os.chdir('/Users/josephwon/Desktop')
            try:
                os.rmdir(targetString)
                print targetString + " deleted!"
            except OSError as exc:
                if not os.path.isdir(targetString):
                    dexi = wx.MessageDialog(None, "The file does not exist", 'Error', wx.ICON_HAND)
                    dexi.ShowModal()
                    pass
                else:
                    raise

        elif command[0] == 'quit' or command[0] == 'kill':
            if ' ' in targetString:
                targetString = targetString.title()
                targetString = targetString.split(" ")
                try:
                    subprocess.call('pkill ' + targetString[0] + "\ " + targetString[1], shell=True)
                except Exception, e:
                    print str(e)
            else:
                try:
                    subprocess.call('pkill ' + targetString, shell=True)
                except Exception, e:
                    print str(e)

        elif command[0] == 'wiki' or command[0] == 'Wiki':
            target = wikipedia.page(targetString)
            webbrowser.open(str(target.url))

        elif command[0] == 'tweet' or command[0] == 'sweet':
            msg = targetString
            command = 'twitter -ejosephwon0310@gmail.com set %s' % msg
            subprocess.call(command, shell=True)

        elif command[0] == 'recommend' and special[-1] == "movie":
            url = 'http://www.imdb.com/title/tt' + str(random.randint(1,2299997))
            webbrowser.open(url)

        # elif command[0] == 'recommend' and 'restaurant' in special:
        #   #TODO: restaurant search Yelp
        #   # del command
        #   # del special
        
        elif special[0] == 'less' or special[0] == "let's" and special[-1] == "selfie" or special[-1] == "cellfee" or special[-1] == "picture":
            subprocess.call('open -a Photo\ Booth ', shell=True)

        # elif command[0] == 'bye' or command[0] == 'by':
        #   self.Destroy()

        else:
            box = wx.MessageDialog(None, "Couldn't hear you", 'Butler', wx.ICON_HAND)
            box.ShowModal()




# class Butler(wx.App):

#   def __init__(self, *args, **kwargs):
#       wx.App.__init__(self, *args, **kwargs)

#   def OnInit(self):
#       frame = Display()
#       frame.Show()
#       return True

if __name__ == '__main__':
    app = wx.App(False)
    frame = Display(parent=None, id=-1)
    frame.Show()
    app.MainLoop()
