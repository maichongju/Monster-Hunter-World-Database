file = open ("data.txt",'r')

list = []
for line in file:
	line = line.rstrip().split(' ')
	words = line[0].split('_')
	variablename = words[0].capitalize()+words[1].capitalize()
	name = "Ammo" + words[0].capitalize() + "Ammo"
	list.append([variablename,name])

print(list)

index = 0
w = "tempWeaponAmmo"
while(index < len(list)):
        print(""" if ({}.{} != null){{
Ammos.Add(new Ammo(Properties.String.{},{}.{},{}.{},{}.{},{}.{}));
}}
""".format(w,list[index+3][0],list[index][1],w,list[index][0]
           ,w,list[index+1][0],w,list[index+2][0],w,list[index+3][0]))
        index+=4
