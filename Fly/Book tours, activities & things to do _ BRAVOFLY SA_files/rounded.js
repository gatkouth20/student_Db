/*butt = getElementsByClassName("butt");
for(var i=0; i < butt.length; i++){
JQ(function(){
        JQ('.butt').corner({
          tl: { radius: 3 },
          tr: { radius: 3 },
          bl: { radius: 3 },
          br: { radius: 3 },
          antiAlias: true,
          autoPad: true,
          validTags: ["div"] });
    
    });    
}

tab_active = getElementsByClassName("tab_active");
for(var i=0; i < tab_active.length; i++){
JQ(function(){
        JQ('.tab_active').corner({
          tl: { radius: 4 },
          tr: { radius: 4 },
          bl: { radius: 1 },
          br: { radius: 1 },
          antiAlias: true,
          autoPad: true,
          validTags: ["div"] });
    
    });    
}

tab_notactive = getElementsByClassName("tab_notactive");
for(var i=0; i < tab_notactive.length; i++){
JQ(function(){
        JQ('.tab_notactive').corner({
          tl: { radius: 4 },
          tr: { radius: 4 },
          bl: { radius: 1 },
          br: { radius: 1 },
          antiAlias: true,
          autoPad: true,
          validTags: ["div"] });
    
    });    
}*/

JQ = $;
JQ(document).ready(
   function()
   {
        JQ('.butt').corner({
          tl: { radius: 3 },
          tr: { radius: 3 },
          bl: { radius: 3 },
          br: { radius: 3 },
          antiAlias: true,
          autoPad: true,
          validTags: ["div"] });
          
        /*JQ('.activity_header').corner({
          tl: { radius: 6 },
          tr: { radius: 6 },
          bl: false,
          br: false,
          antiAlias: true,
          autoPad: true,
          validTags: ["div"] });*/

        JQ('.r_img').corner({
          tl: { radius: 3 },
          tr: { radius: 3 },
          bl: { radius: 3 },
          br: { radius: 3 },
          antiAlias: true,
          autoPad: true,
          validTags: ["div"] });

        
        JQ('.tab_active').corner({
          tl: { radius: 4 },
          tr: { radius: 4 },
          bl: { radius: 1 },
          br: { radius: 1 },
          antiAlias: true,
          autoPad: true,
          validTags: ["div"] });

        JQ('.tab_notactive').corner({
          tl: { radius: 4 },
          tr: { radius: 4 },
          bl: { radius: 1 },
          br: { radius: 1 },
          antiAlias: true,
          autoPad: true,
          validTags: ["div"] });

       JQ('#booking-form-right').corner({
          tl: { radius: 3 },
          tr: { radius: 3 },
          bl: { radius: 3 },
          br: { radius: 3 },
          antiAlias: true,
          autoPad: false,
          validTags: ["div"] });

          
       });

