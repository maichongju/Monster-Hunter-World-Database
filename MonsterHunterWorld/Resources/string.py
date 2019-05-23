words = ["great-sword","long-sword","sword-and-shield","dual-blades","hammer","hunting-horn","lance","gunlance",'switch-axe','charge-blade',"insect-glaive","light-bowgun","heavy-bowgun","bow"]


for word in words:
    temp = word.split('-')
    Name = "WeaponType"
    Value = ""
    for T in temp:
        Name += T.capitalize()
        Value += T.capitalize() + " "
    Value = Value[:-1]
    
    print("""   <data name="{0}" xml:space="preserve">
    <value>{1}</value>
  </data> """.format(Name,Value))
