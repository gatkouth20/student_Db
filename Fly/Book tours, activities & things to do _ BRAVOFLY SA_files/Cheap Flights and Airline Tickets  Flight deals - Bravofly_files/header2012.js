
(function(scope){var sub,sup,main,more,moreItemDiv,itemContainerButton,idFlag="header12_change_flag",idPopup="header12_flags_popup",idMain="page-header";function get(id){return document.getElementById(id);}
function addEvent(elm,evType,fn,useCapture){var r;if(elm.addEventListener){elm.addEventListener(evType,fn,useCapture);r=true;}else if(elm.attachEvent){r=elm.attachEvent("on"+evType,fn);}else{elm["on"+evType]=fn;}
return r;}
function stopBubbling(e){if(e.stopPropagation){e.stopPropagation();}else{e.cancelBubble=true;}}
function isTheTarget(trg){var is=false;if(trg.id==idFlag||(trg.parentNode&&trg.parentNode.id==idFlag)){is=true;}else if(trg.tagName=="IMG"&&(trg.parentNode&&trg.parentNode.id==idFlag)){is=true;}
return is;}
function handleLangMenuVisibility(e){var ev=e||window.event,trg=ev.target||ev.srcElement;if(!isTheTarget(trg)){removeClass(main,"open");}else{stopBubbling(ev);toggleClass(main,["close","open"]);}}
function handleItemContainerVisibility(e){if(!window.jQuery){return;}
jQuery(".menubar").fadeToggle(200);var args=jQuery(".section-navigation-mobile").css('margin-top')=='0px'?[{marginTop:'-50px'},1]:[{marginTop:'0px'},210];jQuery('.section-navigation-mobile').animate(args);}
function removeClass(node,c){node.className=node.className.replace(new RegExp("\\b"+c+"\\b","g"),"");}
function toggleClass(node,c){if(!(c instanceof Array)){return;}
var re=new RegExp("\\b("+c.join("|")+")\\b","g"),attr=node.className;if(!(re.test(attr))){attr+=" "+c[0];}
node.className=attr.replace(re,function(found){return c[found==c[0]?1:0];});}
if(!scope.bravofly){scope.bravofly={};}
if(!scope.bravofly.header){scope.bravofly.header={};}
scope.bravofly.header.init=function(){sup=get(idFlag);sub=get(idPopup);main=get(idMain);itemContainerButton=get("top-opener-mobile");more=get("more-item");moreItemDiv=more&&more.getElementsByTagName("div")[0];if(sup&&sub){addEvent(sup,"click",handleLangMenuVisibility);addEvent(document.body,"click",handleLangMenuVisibility);}
if(more&&moreItemDiv){addEvent(document.body,"click",function(e){moreItemDiv.style.display="none";removeClass(more," open");});addEvent(more,"click",function(e){stopBubbling(e);var visible=(moreItemDiv.style.display==="block");moreItemDiv.style.display=(visible)?"none":"block";toggleClass(more,["close","open"]);});}
if(get("mobile-header-button-id")){addEvent(get("mobile-header-button-id"),"click",function(e){stopBubbling(e);toggleClass(get("menubar"),["menubar-close","menubar-open"]);});}};})(window);;function openMapAgencies()
{width=880;height=635;scroolbars="no";windowname='_blank';popup=window.open('http://agenzieviaggi.volagratis.it/home.htm',windowname,'toolbar=no,scrollbars='+scroolbars+',location=no,directories=no,width='+width+',height='+height);popup.focus();return popup;};