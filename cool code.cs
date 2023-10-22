import random

# Define the player class
class Player:
    def __init__(self, x, y, z):
        self.x = x
        self.y = y
        self.z = z
        self.health = 100

    def move(self, dx, dy, dz):
        self.x += dx
        self.y += dy
        self.z += dz

    def shoot(self):
        # Create a bullet object
        bullet = Bullet(self.x, self.y, self.z)

        # Add the bullet to the game world
        game_world.add_entity(bullet)

# Define the bullet class
class Bullet:
    def __init__(self, x, y, z):
        self.x = x
        self.y = y
        self.z = z
        self.speed = 10

    def move(self):
        self.x += self.speed

# Define the game world class
class GameWorld:
    def __init__(self):
        self.entities = []

    def add_entity(self, entity):
        self.entities.append(entity)

    def update(self):
        for entity in self.entities:
            entity.move()

        # Check for collisions between entities
        for entity1 in self.entities:
            for entity2 in self.entities:
                if entity1 != entity2 and entity1.collides_with(entity2):
                    # Handle the collision

# Create the game world
game_world = GameWorld()

# Create the player
player = Player(0, 0, 0)

# Add the player to the game world
game_world.add_entity(player)

# Game loop
while True:

    # Get the player's input
    player_input = input()

    # Move the player based on the input
    if player_input == "w":
        player.move(0, 1, 0)
    elif player_input == "s":
        player.move(0, -1, 0)
    elif player_input == "a":
        player.move(-1, 0, 0)
    elif player_input == "d":
        player.move(1, 0, 0)

    # Shoot a bullet if the player presses space
    if player_input == " ":
        player.shoot()

    # Update the game world
    game_world.update()

    # Check if the player is dead
    if player.health <= 0:
        print("You died!")
        break
This is just a very basic example, of course. You can add more features to your FPS game, such as different types of weapons, enemies, and levels.

