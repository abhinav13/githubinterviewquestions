def strtok(string, prev_string = [] ):
    #
    
    if string == None:
        return None
    
    if len(string) == 0 :
        return None
        
    if len(prev_string) == 0 :
        
        prev_string.append(string)
                
    elif(prev_string[0] != string): # new call
        
        del prev_string[:]
        prev_string.append(string)
    else:
            try:
                string = prev_string[1]
            except IndexError :
                return None

  #now walk the string to find the first whitespace in the string
    i=0
    string2=None
    string1=string
    #print "string1 " , string1
    while (i < len(string)):
        if(string[i].isspace()):
            mark = i
            while(string[i].isspace()):
                i+=1
                
            #create two string
            # one to return
            # the other is the remainder for the next call
            string1= string[:mark]
            string2= string[i:]
            
            break
        i=i+1
    if(string2 != None and len(string2) != 0 ):
        prev_string.insert(1,string2)
    #print prev_string
    
    return string1    


print strtok("This is a Test")
#print 
print strtok("This is a Test")
#print 
print strtok("Another test")
#print 
print strtok("Another test")
print strtok("Another testing")
print strtok("Another testing")
#print strtok("This is a Test")
#print strtok("This is a Test")
print strtok("ONLYONE")
print strtok("ONLYONE")



print strtok("ONLYONE")
print strtok("ONLYONE")
