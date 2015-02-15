from Cocoa import *
from Foundation import NSObject
import os, sys, subprocess, errno
import speech_recognition as sr
from pygoogle import pygoogle
import webbrowser
import wikipedia
import random
from bs4 import BeautifulSoup
import requests
import logging
# def soundcloud(music):
# 	client = soundcloud.Client(client_id="78274d5e8be892f732eb50cee75b3f5e")

#crawls thorugh your computer and runs the given application/programs
#command is "run " + app name
def crawl(appName):
	appName = appName.lower()
	os.chdir('/Applications')
	root = os.getcwd()
	appList = next(os.walk(root))[1]
	for apps in appList:
		apps = apps.lower()
		print apps
		if apps == appName or apps[:-4] == appName:
			if ' ' in apps:
				try:
					apps = apps.split(" ")
					subprocess.call('open ' + apps[0] + "\ " + apps[1], shell=True)
					break
				except Exception, e:
					print "The app is corrupted or does not exist"
			else:
				try:
					subprocess.call('open ' + apps, shell=True)
					break
				except Exception, e:
					print "The app is corrupted or does not exist"

#search stuff on google and opens up the first result browser
#command is "google" + what you want to search
def googleIt(searchTopic):
	g = pygoogle(searchTopic)
	g.pages = 1
	print '*Found %s results*'%(g.get_result_count())
	urls = g.get_urls()
	print "*List of the URLs on the first page of the result*"
	for url in urls:
		print url
	webbrowser.open(urls[0])
	webbrowser.open("https://www.google.com/#q=" + searchTopic)

def wikiSearch(searchTopic):
	target = wikipedia.page(searchTopic)
	webbrowser.open(str(target.url))

#folder opener which returns the subdirectories you can choose from
#command is "open " + folder name
def openFolder(targetDir):
	#optimize it for windows directories
	os.chdir('/Users/josephwon')
	root = os.path.join(os.getcwd(), targetDir)
	os.chdir(root)
	dirList = next(os.walk(root))[1] #returns the folders in the given directory

	for folders in dirList:
		if folders[0] != '.':
			print folders

	target = raw_input()
	subprocess.call("open ./" + target, shell=True)

#create folders
#command is "create" or "touch"
def createFolder(foldername):
	#change so it can change directories
	os.chdir('/Users/josephwon/Desktop')
	try:
		os.makedirs(foldername)
		print foldername + " created!"
	except OSError as exc:
		if exc.errno == errno.EEXIST and os.path.isdir(foldername):
			print "The folder already exists"
			pass
		else:
			raise

#command is "delete" or "remove"
def deleteFolder(foldername):
	os.chdir('/Users/josephwon/Desktop')
	try:
		os.rmdir(foldername)
		print foldername + " deleted!"
	except OSError as exc:
		if not os.path.isdir(foldername):
			print "The folder does not exist"
			pass
		else:
			raise

#command is "kill" or "quit"
def killAll(processName):
	if ' ' in processName:
		processName = processName.title()
		processName = processName.split(" ")
		try:
			subprocess.call('pkill ' + processName[0] + "\ " + processName[1], shell=True)
		except Exception, e:
			print str(e)
	else:
		try:
			subprocess.call('pkill ' + processName, shell=True)
		except Exception, e:
			print str(e)

#tweet via butler "tweet"
def tweet(line):
	msg = line
	command = 'twitter -ejosephwon0310@gmail.com set %s' % msg
	subprocess.call(command, shell=True)

#legit random "recommend"
def randomMovie():
	url = 'http://www.imdb.com/title/tt' + str(random.randint(1,2299997))
	webbrowser.open(url)

def selfie():
	subprocess.call('open -a Photo\ Booth ', shell=True)

# def urbanspoon(city):
# 	if " " in city:
# 		city.split()
# 		r = requests.get("http://www.urbanspoon.com/lb/2/best-restaurants-" + city[0] + "-" + city[1])
# 	else:
# 		r = requests.get("http://www.urbanspoon.com/lb/2/best-restaurants-" + city)

# 	soup = BeautifulSoup(r.content)

# 	for link in soup.find_all("ul"):
# 		print link

while True:
	print "Butler ready!"


	#Speech Recognition
	r = sr.Recognizer()
	with sr.Microphone() as source:
		audio = r.listen(source)

	print "Butler on duty..."

	try:
		special = str(r.recognize(audio)).split()
		command = str(r.recognize(audio)).split(' ',1)
		targetString = command[1]
	except LookupError:
		print "Couldn't understand!"


	#delete it later
	print command[0]
	print targetString

	#The command tree
	if command[0] == 'run':
		print "Running " + targetString.title() + "!"
		crawl(targetString)
		del command
		del special
		continue

	elif command[0] == 'Google' or command[0] == 'search':
		googleIt(targetString)
		del command
		del special
		continue

	elif command[0] == 'open':
		openFolder(targetString)
		del command
		del special
		continue

	elif command[0] == 'create' or command[0] == 'touch':
		createFolder(targetString)
		del command
		del special
		continue

	elif command[0] == 'delete' or command[0] == 'remove':
		deleteFolder(targetString)
		del command
		del special
		continue

	elif command[0] == 'quit' or command[0] == 'kill':
		killAll(targetString)
		del command
		del special
		continue

	elif command[0] == 'wiki' or command[0] == 'Wiki':
		wikiSearch(targetString)
		del command
		del special
		continue

	elif command[0] == 'tweet' or command[0] == 'sweet':
		tweet(targetString)
		del command
		del special
		continue

	elif command[0] == 'recommend' and special[-1] == "movie":
		randomMovie()
		del command
		del special
		continue

	elif command[0] == 'recommend' and 'restaurant' in special:
		#TODO: restaurant search Yelp
		del command
		del special
		continue

	elif special[0] == 'less' or special[0] == "let's" and special[-1] == "selfie" or special[-1] == "cellfee" or special[-1] == "picture":
		selfie()
		del command
		del special
		continue

	elif command[0] == 'bye' or command[0] == 'by':
		break

	else:
		print "I couldn't hear you"


# if __name__ == '__main__':
# 	main()














