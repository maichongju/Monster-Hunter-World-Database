import os

cwd = os.getcwd()

entries = os.listdir(cwd + '\Weapon')
for item in entries:
	print("  <data name=\"weapon_{}\" xml:space=\"preserve\">".format(item[:-4]))
	print("    <value>Resources\Weapon\{}</value>".format(item))
	print("  </data>")