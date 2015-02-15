import os, sys, subprocess

os.chdir('C:\\')
user = os.environ.get("USERNAME")

filename = raw_input()

root1 = 'C:/Users/'+ user + '/AppData/Local'
root2 = 'C:/Program Files'
root3 = 'C:/Program Files (x86)'

rootMO = root2 + '/Microsoft Office'

if (filename == 'Microsoft Word' or filename == 'Word'):
    filename = 'WINWORD'
    root2 = rootMO
elif (filename == 'Microsoft Excel' or filename == 'Excel'):
    filename = 'EXCEL'
    root2 = rootMO
elif (filename.upper() == 'MICROSOFT ONENOTE' or filename.upper() == 'ONENOTE'):
    filename = 'ONENOTE'
    root2 = rootMO
elif (filename.upper() == 'ATOM'):
    filename = 'atom'
    root2 = root 1

print os.system('cd');

def search(root, filename):
    os.chdir(root)
    for rootPath, subDir, files in os.walk(root):
        print rootPath

        if (filename + '.exe') in files:
            try:
                subprocess.call(os.path.join(rootPath, filename + '.exe'))
                return True;
            except OSError, e:
                print str(e);
        elif (filename + '.EXE') in files:
            try:
                subprocess.call(os.path.join(rootPath, filename + '.EXE'))
                return True;
            except OSError, e:
                print str(e);
    else:
        print "Not here."

# if search(root1, filename):
#     quit()
# elif search(root2, filename):
#     quit()
# elif search(root3, filename):
#     quit()
# else:
#     print "This did not work."

if search(root2, filename):
    quit()
else:
    print "This did not work."
