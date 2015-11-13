/* AJAX basic functionality*/
var dosig_request = [];
//var http_request = [];
var htreq_funcs = [];
var htreq_container = [];
var htreq_type = [];
var ajax_loading_img = "<img src='images/indicator.gif'> <font class='R11DarkBlue'>loading...</font>"
/*
function dosigRequest(reqType,url_val, parameters, return_function, return_type, container_id, content_type){
	dps_ajax_req(reqType, url_val, parameters, return_function, return_type, container_id, content_type)
} */

function dps_ajax_req(reqType, url, parameters, return_function, return_type, container_id, content_type){
	var htcount = dosig_request.length;
	var return_type = return_type == 'xml' ? 'text/xml' : 'text/html';
	dosig_request[htcount] = false;
   return_function = return_function ? return_function : '';

	//dosig_request = '';
	if (window.XMLHttpRequest) { // Mozilla, Safari,...
		 dosig_request[htcount] = new XMLHttpRequest();
		 if (dosig_request[htcount].overrideMimeType) {
				dosig_request[htcount].overrideMimeType(return_type);
		 }
	} else if (window.ActiveXObject) { // IE
		 try {
				dosig_request[htcount] = new ActiveXObject("Msxml2.XMLHTTP");
		 } catch (e) {
				try {
					 dosig_request[htcount] = new ActiveXObject("Microsoft.XMLHTTP");
				} catch (e) {}
		 }
	}

	if (!dosig_request[htcount]) {
		 alert('Cannot create XMLHTTP instance');
		 return false;
	}

   htreq_container[htcount] = container_id;
	htreq_funcs[htcount] = return_function;
   htreq_type[htcount] = return_type;

   if(htreq_container[htcount]){
      document.getElementById(htreq_container[htcount]).innerHTML=ajax_loading_img;
   }
   //eval('dosig_request.onreadystatechange = function() { ' +return_function + '(dosig_request,return_type,container_id); }');
	dosig_request[htcount].onreadystatechange = function() { ajax_response(htcount); }
	dosig_request[htcount].open(reqType, url, true);

	if(reqType == 'POST'){
		content_type = (content_type) ? content_type : 'application/x-www-form-urlencoded';
		dosig_request[htcount].setRequestHeader("Content-type", content_type);
		dosig_request[htcount].setRequestHeader("Content-length", parameters.length);
		dosig_request[htcount].setRequestHeader("Connection", "close");
	}

	dosig_request[htcount].send(parameters);
	return true;
}

function ajax_response(Id){
	var htreq = dosig_request[Id];
	//try{
		if(htreq.readyState == 4) {
			if(htreq.status == 200) {
            var container = htreq_container[Id] ? htreq_container[Id] : '';
				eval(htreq_funcs[Id] + '(htreq,\''+ htreq_type[Id] +'\',\''+ container +'\');');
			}
		}
	/*}
	catch(e){
	}*/
}

function dps_ajax_load_page(page_request,page_type,container_id){
	if(page_type == 'text/html'){
		document.getElementById(container_id).innerHTML=page_request.responseText;
	}
}

function dps_ajax2arr(req){
   //return eval('(' + req.responseText + ')');
   eval(req.responseText);
   return; 
}

function dps_ajax2json(req){
   return eval('(' + req.responseText + ')');
}

function dps_ajax_timer(){
   var mytime = 'mytime='+ new Date().getTime();
   return mytime;
}

function arnie(url, call) {	
	var xmlHttp;
	var exec = call;
	
	if(window.XMLHttpRequest) {
		xmlHttp = new XMLHttpRequest();
		fRequest(xmlHttp);
	}
	else if(window.ActiveXObject) {
		xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
		fRequest(xmlHttp);
	}
	function fRequest(xmlHttp) {
		xmlHttp.open("GET", url+"&dummy="+new Date().getTime(), true);
		xmlHttp.send(null);
		fPass(xmlHttp);	
	}	
	function fPass(xmlHttp) {
		xmlHttp.onreadystatechange=function(){			
			if(xmlHttp.readyState == 4) {
				response = xmlHttp.responseText;				
				exec(response);
			}
			
		}		
	}	
}



















/*
var element_id;
function dps_set_container(id)
{
	element_id=id;

}







function dps_set_div(XMLHttpRequestObject,return_type,element_id)

{

	if(window.document.getElementById(element_id))

		window.document.getElementById(element_id).innerHTML=XMLHttpRequestObject.responseText;

	else if(window.top.document.getElementById(element_id))

		window.top.document.getElementById(element_id).innerHTML=XMLHttpRequestObject.responseText;

	else if(window.parent.document.getElementById(element_id))

		window.parent.document.getElementById(element_id).innerHTML=XMLHttpRequestObject.responseText;

}



function dps_set_select(XMLHttpRequestObject,return_type,element_id)

{



	var response=XMLHttpRequestObject.responseText;

	var valArray=response.split('|');

	var length = valArray.length;

	var i,tmpArray;



	document.getElementById(element_id).options.length = length;

	for(i=0;i<length;i++)

	{

		tmpArray=valArray[i].split('~');

		document.getElementById(element_id).options[i].text=tmpArray[1];

		document.getElementById(element_id).options[i].value=tmpArray[0];

	}

	document.getElementById(element_id).options[0].selected=true;

}



function dps_set_selectXML(XMLHttpRequestObject,return_type,element_id)

{

	var response=XMLHttpRequestObject.responseXML;

	var option=response.getElementsByTagName("option");

	var element=document.getElementById(element_id);

	document.getElementById(element_id).options.length = 0;

	for(i=0;i<option.length;i++)

	{

		value=(option[i].attributes.getNamedItem("value").nodeValue);

		selected=(option[i].attributes.getNamedItem("selected").nodeValue);

		text=option[i].firstChild.nodeValue;

		if(selected=='Y')

			element.options[i]=new Option(text,value,true);

		else

			element.options[i]=new Option(text,value,false);

	}
   

}*/