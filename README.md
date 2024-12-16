# RhythmicSurvivorDemoDB

## Demo for the game Rhythmic Survivor using a REST API to save/load data from the game.

The game is a combination of 2 different game genres, rhythmic game and survival game. Combine the mechanic of follow the music rhythm in the player's movement and attacks in the rhythmic games with the mechanic of survive the enemies waves a specific time until the final boss appears. The player also level up during the game selecting between damage and health, this levels are store during the games in the database so the next time you play you'll start with the levels previously obtained.
Start with a login screen, if the player already have an account check the credentials with the database or you can create an account.
After you succesfully login in you move to the game slots, if you're start a run before you'll have the slot with some data as the character selected or you can create a new game.
Selecting one of the game slots you'll take you to the main menu with a start game button, clicking the button start the game and take you to the game HUD.
If you complete de time and spawn the final boss you'll have the victory screen, if you died before that you'll have the defeat screen. Both screen have a button to restart the game or quit.
To comunicate with the database, the game make request to a REST API (.NET - SQL) and manage the response obtained.

The project contains scripts as:
+ AudioManager: manage the music of the game and update a boolean each time a timer gets the time limit.
+ MyGameManager: manage the spawn of enemies and the game variables for the pause/restart.
+ ServerResponse: personalize class that save the response obtain from the REST API.
+ GUIManager: manage the flow of the menus in the game.
+ HealthBarManger: update the health bars of the player or enemy.
+ Player: manage the player's inputs and variables as health, damage, levels, etc.
+ Enemy: manage the movement and the variables as health, damage, experience, etc.
+ FinalBoss: manage the simple AI of the final boss with variables as health and damage.
+ PlayerAttack: manage the collision of the player's sword.
+ EnemyAttack: manage the collision of the enemy's attack.
+ FinalBossAttack: manage the collision of the final boss attack.

A version of the game without use the REST API is in the repository. This version of the game use the save/load data from a file in the system, saving data in json format.

## Instructions with REST API
+ Clone the repository
+ Set the database with the query or the backup in the folder SQL
+ Open and run the GameAPI project in VS
+ Run the RhythmicSurvivor.exe in the folder Builds\UsingAPISQL
+ Make sure to have the GameAPI running at the same time!

## Instructions without REST API
+ Clone the repository
+ Run the RhythmicSurvivor.exe in the folder Builds\NormalGame