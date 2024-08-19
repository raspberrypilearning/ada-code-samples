import imageio.v2 as imageio
import numpy as np
import math

# Index numbers for RGB values
RED = 0
GREEN = 1
BLUE = 2

# Index numbers for array
ROW = 0
COL = 1

def reflect_image_vertical(img):
  '''Create and return a vertically reflectedimage'''
  width = img.shape[COL]
  reflected_img = np.zeros(img.shape, img.dtype)# create new numpy array
  for r in range(img.shape[ROW]): # process all rows
    for c in range(img.shape[COL]): # process all columns
      new_c = width - c - 1
      reflected_img[r, new_c] = img[r, c]
  return reflected_img

def reflect_image_horizontal(img):
  '''Create and return a horizontally reflected image'''
  height = img.shape[ROW]
  reflected_img = np.zeros(img.shape, img.dtype)# create new numpy array
  for r in range(img.shape[ROW]): # process all rows
    for c in range(img.shape[COL]): # process all columns
      new_r = height - r - 1
      reflected_img[new_r, c] = img[r, c]
  return reflected_img

def rotate_180(img):
  '''Create and return a version of an image rotated through 180 degrees'''
  width = img.shape[COL]
  height = img.shape[ROW]
  rotated_img = np.zeros(img.shape, img.dtype)#create new numpy array
  for r in range(img.shape[ROW]): # process all rows
    for c in range(img.shape[COL]): # process all columns
      new_r = height - r - 1
      new_c = width - c - 1
      rotated_img[new_r, new_c] = img[r, c]
  return rotated_img

def rotate_90(img):
  '''Create and return a version of an image rotated through 90 degrees'''
  # Make a new numpy array with first two dimensions flipped
  print(img.shape)
  rotated_img = np.zeros((img.shape[COL], img.shape[ROW], 3), img.dtype)
  print(rotated_img.shape)
  # Calculate mid points of original image
  img_midr = int(img.shape[ROW]/2)
  img_midc = int(img.shape[COL]/2)
  # Store mid points of new image
  rotated_midr = img_midc
  rotated_midc = img_midr
  for r in range(img.shape[ROW]): # process all rows
    for c in range(img.shape[COL]): # process all columns
      # 90°rotation
      new_r = ((c - img_midc) * 1) + ((r - img_midr) * 0) + rotated_midr - 1
      new_c = ((c - img_midc) * 0) - ((r - img_midr) * 1) + rotated_midc - 1
      rotated_img[new_r, new_c] = img[r, c]
  return rotated_img


def scale_image_50(img):
  '''Create and return a scaled version of an image (50%)'''
  # Calculate size of new array (50%)
  rows = round(img.shape[ROW]/2)
  cols = round(img.shape[COL]/2)
  # Make a new numpy array of correct shape
  scaled_image = np.zeros((rows, cols, 3), dtype=np.uint8)
  # Initialise indices
  scaled_image_r = 0
  scaled_image_c = 0
  # Iterate through image array
  for r in range(0,img.shape[ROW],2): # process all rows, step 2
    for c in range(0,img.shape[COL],2): # process all columns, step 2
      # Calculate colour averages in blocks of 4
      red_avg = min(round((int(img[r, c, RED]) + int(img[r+1, c, RED])+
                 int(img[r, c+1, RED]) + int(img[r+1, c+1, RED]))/4),255)
      green_avg = min(round((int(img[r, c, GREEN]) + int(img[r+1, c, GREEN])+
                 int(img[r, c+1, GREEN]) + int(img[r+1, c+1, GREEN]))/4),255)
      blue_avg = min(round((int(img[r, c, BLUE]) + int(img[r+1, c, BLUE])+
                 int(img[r, c+1, BLUE]) + int(img[r+1, c+1, BLUE]))/4),255)
      # write average values to pixel in scaled image
      scaled_image[scaled_image_r, scaled_image_c]=(red_avg, green_avg, blue_avg)    
      scaled_image_c +=1 # Increment column index
    scaled_image_r += 1 # Increment row index
    scaled_image_c = 0 # Reset column index
  return scaled_image



def main():
  # read in image file
  infile = "balloon-100.jpg"
  original_img = imageio.imread(infile)
  # reflect image vertically
  reflected_img = reflect_image_vertical(original_img)
  imageio.imwrite("reflected_vertical.jpg", reflected_img)
  # reflect image horizontally
  reflected_img = reflect_image_horizontal(original_img)
  imageio.imwrite("reflected_horizontal.jpg", reflected_img)
  # rotate image (180°)
  rotated_img = rotate_180(original_img)
  imageio.imwrite("rotated_180.jpg", rotated_img)
  # rotate image (90°)
  rotated_img = rotate_90(original_img)
  imageio.imwrite("rotated_90.jpg", rotated_img)
  # scale image
  scaled_img = scale_image_50(original_img)
  imageio.imwrite("scaled.jpg", scaled_img)

  
if __name__ == "__main__":
  main()
