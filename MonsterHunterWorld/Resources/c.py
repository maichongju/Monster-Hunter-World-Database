file = open("data.txt",'r')
for line in file:
    result = ''
    words = line.strip().split('_')
    for word in words:
        result+= word.capitalize()
    print("  <data name=\"Monster{}\" xml:space=\"preserve\">".format(result))
    print("    <value>{}</value>".format(words[1].capitalize()))
    print("  </data>")
file.close()
