echo "Enter the name of the files you want to push"
read files
echo "Enter the message for the commit"
read message
git add $files
git config --global user.email anna.ndiaye1@ism.edu.sn
git config --global user.name annandiaye11
git commit -m "$message"
git push