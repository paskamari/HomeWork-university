var cnv = document.getElementById('paint');

var ctx = cnv.getContext('2d');

var painting = false;

cnv.onmousemove = function (event){
	if(painting){
		var x = event.offsetX;
		var y = event.offsetY;
		ctx.lineTo(x,y);
		ctx.stroke();
	}
};

cnv.onmousedown=function(event){
	var x = event.offsetX;
	var y = event.offsetY;

	ctx.beginPath();
	ctx.moveTo(x,y);
	ctx.strokeStyle=randColor();
	ctx.lineWidth=rand(1,10);
	painting = true;
}

cnv.onmouseup=function(){
	painting = false;
}

function rand(a,b){
	return Math.floor(Math.random()*(b-a+1))+a;
}

function randColor(){
	var c='#';
	for(var i=0;i<6;i++){
		c+=rand(0,16).toString(16);
	}
	return c;
}