
function dateGreaterThan(strDate1,strDate2){var dd,mm,yyyy;var date1,date2;dd=strDate1.substring(0,2);mm=strDate1.substring(2,4);yyyy=strDate1.substring(4);date1=new Date(yyyy,mm-1,dd);dd=strDate2.substring(0,2);mm=strDate2.substring(2,4);yyyy=strDate2.substring(4);date2=new Date(yyyy,mm-1,dd);if(date1>date2)
return true;return false;}
function dateGreaterEqual(strDate1,strDate2){var dd,mm,yyyy;var date1,date2;dd=strDate1.substring(0,2);mm=strDate1.substring(2,4);yyyy=strDate1.substring(4);date1=new Date(yyyy,mm-1,dd);dd=strDate2.substring(0,2);mm=strDate2.substring(2,4);yyyy=strDate2.substring(4);date2=new Date(yyyy,mm-1,dd);if(date1>=date2)
return true;return false;}
function openpopupWindow(popupURL,width,height)
{popupWindow=window.open(popupURL,"popupWindowDoc","scrollbars=no,location=no,toolbar=no,directories=no,status=no,resizable=no,height="+height+",width="+width);}
function openWindow(popupURL,width,height)
{popupWindow=window.open(popupURL,"popupWindowDoc","scrollbars=yes,location=no,toolbar=no,directories=no,status=no,resizable=no,height="+height+",width="+width);}
function isEMailAddress(elem){var str=elem.value;var re=/^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$/;if(!str.match(re))
return false;else
return true;}
function MM_openBrWindow(theURL,winName,features){window.open(theURL,winName,features);}
function isValidText(elem){var str=elem.value;var re=/^[a-zA-Z0-9\s.\-_;,']+$/;if(!str.match(re))
return true;else
return false;}
function validateSplittedPhoneNumber(phoneNationalPrefix,phoneNumber)
{if(isUnsignedInteger(phoneNationalPrefix)&&isUnsignedInteger(phoneNumber))
{return true;}
else
{return false;}}
function isUnsignedInteger(s)
{return(s.toString().search(/^[0-9]+$/)==0);};