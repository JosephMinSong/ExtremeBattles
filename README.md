# <h1 align="center"> Extreme Battles </h1>
## <p align="center"> <img width="30" src="https://github.com/JosephMinSong/JosephMinSong/assets/129890601/9c73b91d-dea1-443d-88d2-8c11617850fd" /> Game inspired by the popular game "Cuphead" <img width="30" src="https://github.com/JosephMinSong/JosephMinSong/assets/129890601/9c73b91d-dea1-443d-88d2-8c11617850fd" /> </p>

# Table of Contents
* [General Info](#general-information)
* [Technologies Used](#technologies-used)
* [Screenshots of Game and Code Snippets](#screenshots-of-game-and-code-snippets)

## General Information
Extreme battles is a game where you, the ninja frog, have to defeat the mega-tree that stands in your way. Using intuitive controlls to move and jump, you must not only survive by jumping onto moving platforms that move across the stage, but also dodge incoming attacks from the enemy. Inspired by one of the hardest levels, in my opinion, in Cuphead, I wanted to recreate the extreme battle that I personally had with this level as it was so much fun to play. 

## Technologies Used
- Extreme battles uses Unity as it's engine
- It has multiple scripts written in C# for player movement, terrain spawning, boss movement, and more
- Each terrain is destroyed off screen as to minimize the number of objects active to reduce lag time and enhance user experience
- Free assets from the Unity store were used to create player, terrain, background, and boss
- Animations are set for both the player and boss (idle, running, jumping, and attacking) using the animator feature in Unity

## Screenshots of Game and Code Snippets
<h2 align="center"> Upon starting the game, you start the far left while the boss starts on the far right </h2>

![extremebattles](https://github.com/JosephMinSong/ExtremeBattles/assets/129890601/373cc10e-53a5-4cac-bc0e-001d8ca46fc2)

<h2 align="center">Intuitive horizonal input values so that it is also compatible with controllers</h2>

```cs
void Update()
    {   
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {   
            rb.velocity = Vector2.up * jumpStrength;
        }

        UpdateAnimationState();

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bulletPrefab, LaunchOffset.position, LaunchOffset.rotation);
        }
    }
```
