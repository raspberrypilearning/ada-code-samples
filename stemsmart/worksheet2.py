import imageio.v2 as imageio
import numpy as np

# Index numbers for RGB values
RED = 0
GREEN = 1
BLUE = 2

# Index numbers for array
ROW = 0
COL = 1

def apply_sepia_transformation(img):
  '''Create and return a sepia version of an image'''
  sepia_img = np.zeros(img.shape, dtype=np.uint8)#create new numpy array
  for r in range(img.shape[ROW]): # process all rows
    for c in range(img.shape[COL]): # process all columns
      red = img[r, c, RED] # original red value
      green = img[r, c, GREEN] # original green value
      blue = img[r, c, BLUE] # original blue value
      new_red = min(round(.393*red + .769*green + .189*blue), 255)
      new_green = min(round(.349*red + .686*green + .168*blue), 255)
      new_blue = min(round(.272*red + .534*green + .131*blue), 255)
      sepia_img[r, c] = (new_red, new_green, new_blue)
  return sepia_img


def main():
  # read in image file
  infile = "balloon-100.jpg"
  original_img = imageio.imread(infile)
  # sepia transformation
  sepia_img = apply_sepia_transformation(original_img)
  imageio.imwrite("sepia.jpg", sepia_img) 

  
if __name__ == "__main__":
  main()
