import os, sys, subprocess

os.chdir('C:\\')
#later will change to voice recognition feature

filename = raw_input() + '.exe'
root = 'C:\\Users\\' + str(getLogin()) + '\\AppData\\Local\\'

def crawl(root, filename):
	for path, dirs, files in os.walk(root):
		print path
		for f in files:
			if f == filename:
				try:
					subprocess.call(root + '\\' + f + '\\' + f + 'f.exe');
				except (OSError, e):
					print "BUGS!"

# for path, dirs, files in os.walk(root):
# 	print path
# 	for f in files:
# 		if f == filename:
# 			subprocess.call('/Applications/' + f + '.app/Contents/MacOS/' + f)
# 			break





crawl(root, filename)
