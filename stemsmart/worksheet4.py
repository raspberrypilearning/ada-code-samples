import imageio.v2 as imageio
import numpy as np

# Index numbers for RGB values
RED = 0
GREEN = 1
BLUE = 2

# Index numbers for array
ROW = 0
COL = 1


def reflect_image_vertical(img):
  '''Create and return a vertically reflectedimage'''
  reflected_img = np.zeros(img.shape, img.dtype)# create new numpy array
  width = img.shape[COL]
  for row in range(img.shape[ROW]): # process all rows
    for col in range(img.shape[COL]): # process all columns
      new_col = width - col - 1
      reflected_img[row, new_col] = img[row, col]
  return reflected_img


def reflect_image_horizontal(img):
  '''Create and return a horizontally reflected image'''
  reflected_img = np.zeros(img.shape, img.dtype)# create new numpy array
  height = img.shape[ROW]
  for row in range(img.shape[ROW]): # process all rows
    for col in range(img.shape[COL]): # process all columns
      new_row = height - row - 1
      reflected_img[new_row, col] = img[row, col]
  return reflected_img


def rotate_180(img):
  '''Create and return a version of an image rotated through 180 degrees'''
  rotated_img = np.zeros(img.shape, img.dtype)#create new numpy array
  width = img.shape[COL]
  height = img.shape[ROW]
  for row in range(img.shape[ROW]): # process all rows
    for col in range(img.shape[COL]): # process all columns
      new_row = height - row - 1
      new_col = width - col - 1
      rotated_img[new_row, new_col] = img[row, col]
  return rotated_img


def rotate_90(img):
  '''Create and return a version of an image rotated through 90 degrees'''
  # Make a new numpy array with first two dimensions flipped
  new_width = img.shape[ROW]
  new_height = img.shape[COL]
  rotated_img = np.zeros((new_height, new_width, 3), img.dtype)
  for row in range(img.shape[ROW]): # process all rows in original image
    for col in range(img.shape[COL]): # process all columns in original image
      # 90°rotation
      new_row  = col
      new_col = new_width - row - 1
      rotated_img[new_row, new_col] = img[row, col]
  return rotated_img


def scale_image_50(img):
  '''Create and return a scaled version of an image (50%)'''
  # Calculate size of new array (50%)
  rows = round(img.shape[ROW]/2)
  cols = round(img.shape[COL]/2)
  # Make a new numpy array of correct shape
  scaled_img = np.zeros((rows, cols, 3), img.dtype)
  # Initialise indices
  scaled_img_row = 0
  scaled_img_col = 0
  # Iterate through image array
  for row in range(0,img.shape[ROW],2): # process all rows, step 2
    for col in range(0,img.shape[COL],2): # process all columns, step 2
      # Calculate colour averages in blocks of 4
      red_avg = min(round((int(img[row, col, RED]) + int(img[row+1, col, RED])+
                 int(img[row, col+1, RED]) + int(img[row+1, col+1, RED]))/4),255)
      green_avg = min(round((int(img[row, col, GREEN]) + int(img[row+1, col, GREEN])+
                 int(img[row, col+1, GREEN]) + int(img[row+1, col+1, GREEN]))/4),255)
      blue_avg = min(round((int(img[row, col, BLUE]) + int(img[row+1, col, BLUE])+
                 int(img[row, col+1, BLUE]) + int(img[row+1, col+1, BLUE]))/4),255)
      # write average values to pixel in scaled image
      scaled_img[scaled_img_row, scaled_img_col]=(red_avg, green_avg, blue_avg)    
      scaled_img_col +=1 # Increment column index
    scaled_img += 1 # Increment row index
    scaled_img_col = 0 # Reset column index
  return scaled_img


def main():
  # read in image file
  infile = "labrador-100.jpg"
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
