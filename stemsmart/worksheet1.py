# STEM SMART materials
# See copyright information in the stemsmart folder

# STEM SMART materials
# See copyright information in the stemsmart folder

import imageio
import numpy as np

# Index numbers for RGB values
RED = 0
GREEN = 1
BLUE = 2

def display_image_properties(img):
  '''Display some information about the image.'''
  print(f"Type: {type(img)}")
  print(f"Shape: {img.shape}")
  print(f"Data type: {img.dtype}")
  print("\n")
  

def display_some_pixel_data(img):
  '''Display some information about specific pixels.'''
  # RGB values of the top left pixel.
  print(f"RGB:", img[0][0])
  # Red value of top left pixel.
  print(f"R: {img[0][0][RED]}")
  # Green value of top left pixel.
  print(f"G: {img[0][0][GREEN]}")
  # Blue value of the top left pixel.
  print(f"B: {img[0][0][BLUE]}")
  print("\n")


def turn_pixels_blue(img):
  '''Change colour of all pixels to blue.'''
  for row in range(img.shape[0]):
    for col in range(img.shape[1]):
      img[row][col][RED] = 0
      img[row][col][GREEN] = 0
      img[row][col][BLUE] = 255
      

def create_yellow_square(img):
  '''Create a yellow square within image.'''
  for row in range(40, 60):
    for col in range(90, 110):
      img[row][col][RED] = 255
      img[row][col][GREEN] = 255
      img[row][col][BLUE] = 0


def main():
  # img1 - existing image
  infile = "balloon-100.jpg" 
  img1 = imageio.imread(infile) 
  display_image_properties(img1)
  display_some_pixel_data(img1)
  # img2 - new image
  img2 = np.zeros((100, 200, 3), dtype=np.uint8)
  display_image_properties(img2)
  # img3 - new image same shape as img2
  img3 = np.zeros(img2.shape, img2.dtype)
  display_image_properties(img3) 
  turn_pixels_blue(img3) 
  imageio.imwrite("blue_image.jpg", img3)
  create_yellow_square(img3)
  imageio.imwrite("yellow_square.jpg", img3)

  
if __name__ == "__main__":
  main()
