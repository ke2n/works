<?
	include "sess_func.php";
	session_start(); 
	if(!$_SESSION['ID']){
		GoTo('잘못된 경로로 접근하셨습니다!', '../html/main.html');
		return;
	}
?>