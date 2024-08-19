import imageio.v2 as imageio
import numpy as np

RED_INDEX = 0
GREEN_INDEX = 1
BLUE_INDEX = 2

ROW_INDEX = 0
COL_INDEX = 1
RGB_INDEX = 2

def alter_brightness(img, factor):
  '''Create and return a version of an image with adjusted contrast'''
  multiplier = 1 + factor
  new_img = np.zeros(img.shape, dtype=np.uint8)#create new numpy array
  for row in range(img.shape[ROW_INDEX]): # process all rows
    for col in range(img.shape[COL_INDEX]): # process all columns
      for rgb in range(img.shape[RGB_INDEX]): # process all colours
        new_value = max(min(rgb*multiplier, 255),0)
        new_img[row][col][rgb] = new_value
  return new_img

def alter_contrast(img, factor, s):
  '''Create and return a version of an image with adjusted contrast'''
  multiplier = 1 + factor
  new_img = np.zeros(img.shape, dtype=np.uint8)#create new numpy array
  for row in range(img.shape[ROW_INDEX]): # process all rows
    for col in range(img.shape[COL_INDEX]): # process all columns
      for rgb in range(img.shape[RGB_INDEX]): # process all colours
        new_value = max(min(multiplier*(rgb-s)+s, 255),0)
        new_img[row][col][rgb] = new_value
  return new_img

def alter_contrastv2(img, factor, s):
  '''Create and return a brighter version of an image'''
  multiplier = 1 + factor
  new_img = np.zeros(img.shape, dtype=np.uint8)#create new numpy array
  for row in range(img.shape[ROW_INDEX]): # process all rows
    for col in range(img.shape[COL_INDEX]): # process all columns
      for rgb in range(img.shape[RGB_INDEX]): # process all colour codes
        new_img[row,col,rgb] = max(min(((1.5*img[row,col,rgb])+50), 255),0)
  return new_img

def main():
  # read in image file
  infile = "balloon-100.jpg"
  original_img = imageio.imread(infile)
  # alter brightness (value between -1.0 and + 1.0
  #amount = 0.9
  #new_img = alter_brightness(original_img, amount)
  #imageio.imwrite("adjusted_b.jpg", new_img)
  # alter contrast
  factor = 0.3
  sample = 127
  new_img = alter_contrastv2(original_img, factor, sample)
  imageio.imwrite("adjusted_c_v3.jpg", new_img)

  
if __name__ == "__main__":
  main()
