<html>
	<head>
		<script src="./lib/long.min.js"></script>
		<script src="./lib/bytebuffer.min.js"></script>
		<script src="./lib/protobuf.min.js"></script>
		<!--<script src="./lib/jquery-2.1.4.min.js"></script>-->
		<script src="//code.jquery.com/jquery-2.1.4.min.js"></script>

	</head>
	<body>
	

	<script>
			var ProtoBuf = dcodeIO.ProtoBuf;
			var builder = ProtoBuf.loadProtoFile("proto/Message.proto"),
			MessageBuilder = builder.build("Msg"),
			Message = MessageBuilder;
			
			var msg = new Message(12, 32000, "Message", "Author");

			var byteBuffer = msg.encode();
			///

			
			///
			var buffer = byteBuffer.toArrayBuffer(); 

			$(document).ready(function(){
				$("#start").click(function(){ 
					var x = document.getElementById("log");
						   
					if ("WebSocket" in window) {
					ws = new WebSocket("ws://localhost:8181/");
					ws.onopen = function() {
						document.getElementById("send").disabled = false;
					};
					ws.onmessage = function(evt) {     
						$("#data").append(evt.data+"<br>");
					};
					ws.onclose = function() {
						alert("socket closed");
					};
				   
					}
					else
					{alert("The browser doesn't support WebSocket.");}
					
					
					$("#send").click(function(){			
						//var dv = new Uint8Array([10,20,30,40,50,60,70,80,90,100]);
						//var mBlob = new Blob([buffer], {type: 'application/octet-binary'});
						ws.send(buffer);

					})
				 
				})
			});
	</script>
	

	<!-- <input id="msg" type="text" value=""/> --> <input id="start" type="button" value="Start"/><br>
	<input id="send" type="button" value="Send" disabled/>
	<div id="data">	</div>



	</body>
</html>

			