# STEM SMART materials
# See copyright information in the stemsmart folder

import imageio.v2 as imageio
import numpy as np

# Index numbers for array
ROW = 0
COL = 1
RGB = 2

def alter_brightness(img, bias):
  '''Create and return copy of image with adjusted brightness'''
  new_img = np.zeros(img.shape, img.dtype)#create new numpy array
  for row in range(img.shape[ROW]): # process all rows
    for col in range(img.shape[COL]): # process all columns
      for rgb in range(img.shape[RGB]): # process all colours
        new_img[row,col,rgb] = max(min(((img[row,col,rgb])+bias), 255),0)
  return new_img


def main():
  # read in image file
  infile = "balloon-100.jpg"
  original_img = imageio.imread(infile)
  # alter brightness
  amount = -50
  new_img = alter_brightness(original_img, amount)
  imageio.imwrite("adjusted.jpg", new_img)


if __name__ == "__main__":
  main()
