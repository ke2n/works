
/*
NHN UIT Lab. WebStandardization Team (http://html.nhndesign.com/)
Jeong, Chan Myeong 070601~070630
*/

/* 
Used Hack 

IE6 & Below 
{ property:value; _property:value;}

IE7 Only
*:first-child+html #selector

*/

/* default.css - Type Selector Definition */
body { background:#4d4d4d url(/xe/modules/install/tpl/images/installBg.gif) repeat-x;}

/* Content */
#box { position:relative; left:50%; margin:120px 0 0 -380px; width:750px;}
#box h1 { margin:0; }

#content { position:relative; padding:25px 20px 20px 20px; overflow:hidden; background:#ffffff;}
#content h2 { font-size:1em; padding-left:.5em; margin:0 0 1em 0;}
#content blockquote { padding:10px; margin:0; border:1px solid #c9c9c9; margin-bottom:10px; color:#696969; line-height:20px;}
#agreement { border:1px solid #c9c9c9; height:15em; padding:1.2em; overflow:auto; color:#696969; line-height:1.25em; margin-bottom:20px;}

.iePngFix { display:block; }

div.buttonCenter { text-align:center; }

.tableType6 { border:2px solid #c1c0bd; border-left:none; border-right:none; width:100%; margin-bottom:20px;}
#content .tableType6 th { border-top:1px solid #fbfbfb; border-bottom:1px solid #e4e4e4; background:#f5f5f5; padding:10px 10px 10px 2em; font-weight:normal; text-align:left; color:#606060;}
#content .tableType6 td { border-bottom:1px solid #ededed; padding:10px 10px 7px 10px; color:#7b7972; line-height:1.25em;}
#content .tableType6 input,
#content .tableType6 textarea,
#content .tableType6 select { vertical-align:middle;}
#content .tableType6 td .w100 { width:100%; display:block;}
#content .tableType6 td .checkbox { margin:-3px;}
#content .tableType6 td p { line-height:1.4em;}
#content .tableType6 .borderBottomNone { border-bottom:none;}
#content .tableType6 .none { color:#c95b53;}

#content .tableType7 { border:2px solid #c1c0bd; border-left:none; border-right:none; width:100%; margin-bottom:20px;}
#content .tableType7 th { border-bottom:1px solid #e4e4e4; background:#e8e8e8; padding:10px 10px 10px 2em; font-weight:normal; text-align:left; color:#606060;}
#content .tableType7 th.second { background:#f5f5f5;}
#content .tableType7 td { border-bottom:1px solid #ededed; padding:10px 10px 7px 10px; color:#7b7972; line-height:1.25em; font-size:.9em;}
#content .tableType7 .hr { border-bottom:1px solid #b8b8b8;}
#content .tableType7 input,
#content .tableType7 textarea,
#content .tableType7 select { vertical-align:middle;}
#content .tableType7 select { width:100%; }
#content .tableType7 select option { letter-spacing:-1px; }
#content .tableType7 td .w100 { width:100%; display:block;}
#content .tableType7 td .checkbox { margin:-3px;}
#content .tableType7 td p { line-height:1.4em; margin:5px 0 0 0; padding:0;}
#content .tableType7 .borderBottomNone { border-bottom:none;}
#content .tableType7 .none { color:#c95b53;}

a.manual { background:url(/xe/modules/install/tpl/images/iconManual.gif) no-repeat left top; vertical-align:middle; display:inline-block; width:12px; height:13px; overflow:hidden; line-height:0; font-size:1px; text-decoration:none;}
