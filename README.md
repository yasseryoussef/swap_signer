# swap_signer
swap_signer is a .net 7 application works as a local rest api to sign eta invoice using http
swap_signer can intgrate with any application desktop or web
swap_signer works the same as itida web signer 
the application have 2 api 
the first api is for invoice signing 

updated now 4 paramters for the new segnatrue from egypt trust watch data 
so the fourth paramter is the dll name

uri for sign invopice http://localhost:5111/api/signdoc?UseSerial={use_serial}&&TokenName={na}&&TokenPin={pin}&dll={SignatureP11.dll}
takes 3 paramtes 
First paramter is integer UseSerial 1 if you are sending certficate serial number 0 if you send certficate name
second paramter is certficate name or serial 
third paramter is token pin 
paramters are send as query string
this api will sigen the invoice and retrun a full signed document 

the Second  api is for recipte
api uir is http://localhost:5111/api/SigenRecipt

this link for published file to implement in your application
https://www.mediafire.com/folder/kcay9w8uqj1ww/published

this link is for a setup file you can insttal on client machien 
after install make sure to run the application from start menu or restart your computer  
application will add to startup menu autamtic 
https://www.mediafire.com/file/y4vk32qqyzdur9i/swap_web_signer.exe/file





