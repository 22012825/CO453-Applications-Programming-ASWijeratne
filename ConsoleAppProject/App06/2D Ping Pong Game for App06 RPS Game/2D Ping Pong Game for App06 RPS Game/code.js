<html>
<head>
<title>2D Ping Pong Game for App06 RPS Game</title>
        <meta charset="utf-8" />


var p5Inst = new p5(null, 'sketch');

window.preload = function () {
  initMobileControls(p5Inst);

  p5Inst._predefinedSpriteAnimations = {};
  p5Inst._pauseSpriteAnimationsByDefault = false;
  var animationListJSON = {"orderedKeys":["34d03df2-a3a7-43ce-b7a3-a71337cb1f6d"],"propsByKey":{"34d03df2-a3a7-43ce-b7a3-a71337cb1f6d":{"name":"sports_billards","sourceUrl":null,"frameSize":{"x":400,"y":400},"frameCount":1,"looping":true,"frameDelay":12,"version":"IJcxjKtWADfNeXOhBYmKdL87EflGix30","categories":["backgrounds"],"loadedFromSource":true,"saved":true,"sourceSize":{"x":400,"y":400},"rootRelativePath":"assets/34d03df2-a3a7-43ce-b7a3-a71337cb1f6d.png"}}};
  var orderedKeys = animationListJSON.orderedKeys;
  var allAnimationsSingleFrame = false;
  orderedKeys.forEach(function (key) {
    var props = animationListJSON.propsByKey[key];
    var frameCount = allAnimationsSingleFrame ? 1 : props.frameCount;
    var image = loadImage(props.rootRelativePath, function () {
      var spriteSheet = loadSpriteSheet(
          image,
          props.frameSize.x,
          props.frameSize.y,
          frameCount
      );
      p5Inst._predefinedSpriteAnimations[props.name] = loadAnimation(spriteSheet);
      p5Inst._predefinedSpriteAnimations[props.name].looping = props.looping;
      p5Inst._predefinedSpriteAnimations[props.name].frameDelay = props.frameDelay;
    });
  });

  function wrappedExportedCode(stage) {
    if (stage === 'preload') {
      if (setup !== window.setup) {
        window.setup = setup;
      } else {
        return;
      }
    }


//create the ball, playerPaddle and computerPaddle as sprite objects
var ball = createSprite(200,200,10,10);
var playerPaddle = createSprite(203,377,40,10);
var computerPaddle = createSprite(200,25,40,10);
var goal1 = createSprite(200, 395,100,10);
var goal2 = createSprite(200, 5,100,10);
var border1 = createSprite(360, 200,10,800);
var border2 = createSprite(40, 200,10,800);
var debug1 = createSprite(18, 200,35,800);
var debug2 = createSprite(382, 200,35,800);


debug1.shapeColor = 'purple';
debug2.shapeColor = 'purple';
border1.shapeColor = 'white';
border2.shapeColor = 'white';
ball.shapeColor = 'white';
playerPaddle.shapeColor = 'purple';
computerPaddle.shapeColor = 'red';
goal1.shapeColor = 'Blue';
goal2.shapeColor = 'Blue'; 


//variable to store different state of game
var gameState = "serve";
var computerScore = 0;
var playerScore = 0;
if (gameState === "play" || gameState === "serve") {
  


playSound("X2Download.com---One-Summer's-Day---Spirited-Away--Piano-Tutorial--(Synthesia)-(128-kbps).mp3") ;

  
} 
function draw() {

//clear the screen
createEdgeSprites();
textSize(20);
background("green");
ball.bounceOff(border1); 
ball.bounceOff(border2);

if (ball.isTouching(goal1)) {
  playSound("assets/category_tap/negative_select_2.mp3", false);
  
}
if (ball.isTouching(goal2)) {
  playSound("assets/category_tap/negative_select_1.mp3", false);
  
}
if (ball.isTouching(playerPaddle)) {
  playSound("assets/default.mp3", false);
  ball.velocityX - 1;
  ball.velocityY - 1;
}
if (ball.isTouching(computerPaddle)) {
  playSound("assets/default.mp3", false);
  ball.velocityX + 1;
  ball.velocityY + 1;
}

if (ball.isTouching(border1)) {
  playSound("assets/default.mp3", false);
  
}
if (ball.isTouching(border2)) {
  playSound("assets/default.mp3", false);
  
}
if (ball.isTouching(edges)) {
  playSound("assets/default.mp3", false);
  
}
if (ball.isTouching(debug1)) {
  gameState = "serve";
}
if (ball.isTouching(debug2)) {
  gameState = "serve";
}

  //place info text in the center
  if (gameState === "serve") {
    fill("Aqua");
    text("Press Space to Serve",150,180);
  }
   text(computerScore, 60, 172);
   text(playerScore, 60, 222);
   
  
  //make the player paddle move with the mouse's y position
  playerPaddle.x = World.mouseX;
  
  //AI for the computer paddle
  //make it move with the ball's y position
  computerPaddle.x = ball.x;
  
  //draw line at the centre
  drawnet();
  
  //create edge boundaries
  //make the ball bounce with the top and the bottom edges
  createEdgeSprites();
  ball.bounceOff(edges);
  ball.bounceOff(playerPaddle);
  ball.bounceOff(computerPaddle);
 
  
  //serve the ball when space is pressed
  if (keyDown("space") && gameState === "serve") {
    serve();
    gameState = "play";
  }
  
 
  //reset the ball to the centre if it crosses the screen
  if(ball.isTouching(goal1) || ball.isTouching(goal2)) {
    
    if (ball.isTouching(goal1)) {
      computerScore = computerScore + 1;
    }
  if (ball.isTouching(goal2)) {
      playerScore = playerScore + 1;
  }
      reset();
    gameState = "serve";
  }
  
  if (playerScore === 10 || computerScore === 10) {
    fill("Aqua");
    gameState = "over";
    fill("Yellow");
    text("Game Over!", 120, 260);
    fill("Yellow");
    text("Press 'R' to restart   ", 123, 130);
    
  }
  if (keyDown("R") && gameState === "over") {
    gameState = 'serve';
    computerScore = 0;
    fill ("White");
    playerScore = 0;
    fill ("White"); 
  }
   
  drawSprites();
}

function drawnet(){
 for (var i = 0; i < 400; i=i+20) {
    line(i,200,i+10,200);
  }
}
function serve() {
  ball.velocityX = 9;
  ball.velocityY = 5;
}

function reset() {
  ball.x = 200;
  ball.y = 200;
  ball.velocityX = 0;
  ball.velocityY = 0;
}

// -----
    try { window.draw = draw; } catch (e) {}
    switch (stage) {
      case 'preload':
        if (preload !== window.preload) { preload(); }
        break;
      case 'setup':
        if (setup !== window.setup) { setup(); }
        break;
    }
  }
  window.wrappedExportedCode = wrappedExportedCode;
  wrappedExportedCode('preload');
};

window.setup = function () {
  window.wrappedExportedCode('setup');
};
