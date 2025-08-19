# STEM SMART materials
# See copyright information in the stemsmart folder

import imageio.v2 as imageio
import numpy as np

# Index numbers for array
RED = 0
GREEN = 1
BLUE = 2

def alter_brightness(img, bias):
  '''Create and return copy of image with adjusted brightness'''
  new_img = np.zeros(img.shape, img.dtype)#create new numpy array
  for row in range(img.shape[0]): # process all rows
    for col in range(img.shape[1]): # process all columns
      new_img[row,col,RED] = max(min(((int(img[row,col,RED]))+ bias), 255),0)
      new_img[row,col,GREEN] = max(min(((int(img[row,col, GREEN]))+ bias), 255),0)
      new_img[row,col,BLUE] = max(min(((int(img[row,col,BLUE]))+ bias), 255),0)
  return new_img

def alter_contrast(img, contrast_factor, s):
  '''Create and return copy of image with adjusted contrast'''
  new_img = np.zeros(img.shape, img.dtype)#create new numpy array
  for row in range(img.shape[0]): # process all rows
    for col in range(img.shape[1]): # process all columns
        new_img[row,col,RED] =  (contrast_factor * (int(img[row,col,RED]) - s)) + s
        new_img[row,col,GREEN] =  (contrast_factor * (int(img[row,col,GREEN]) - s)) + s
        new_img[row,col,BLUE] =  (contrast_factor * (int(img[row,col,BLUE]) - s)) + s
  return new_img


def main():
  # read in image file
  infile = "balloon-100.jpg"
  original_img = imageio.imread(infile)
  # alter brightness
  amount = -50
  new_img1 = alter_brightness(original_img, amount)
  imageio.imwrite("brightness.jpg", new_img1)
  # alter contrast
  new_img2 = alter_contrast(original_img, 0.3, 127)
  imageio.imwrite("contrast.jpg", new_img2)


if __name__ == "__main__":
  main()
