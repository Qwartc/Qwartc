import cv2

def paint(results, img):
    for(x,y,w,h) in results:
        cv2.rectangle(img, (x,y), (x + w, y + h), (0, 0, 225), thickness=3)



paths = ["faces.jpg", "people.jpg"]
face_img = cv2.imread(paths[0])
#body_img = cv2.imread(paths[1])

gray_face_img = cv2.cvtColor(face_img, cv2.COLOR_BGR2GRAY)
#gray_body_img = cv2.cvtColor(body_img, cv2.COLOR_BGR2GRAY)

faces = cv2.CascadeClassifier('data/haarcascades/haarcascade_frontalface_default.xml')
#bodyies = cv2.CascadeClassifier('data/haarcascades/haarcascade_fullbody.xml')

results_face = faces.detectMultiScale(gray_face_img, scaleFactor=2, minNeighbors=4)
#results_body = bodyies.detectMultiScale(gray_body_img, scaleFactor=6, minNeighbors=12)

paint(results_face, face_img)
#paint(results_body, body_img)

cv2.imshow("Results_face", face_img)
#cv2.imshow("Results_body", body_img)
cv2.waitKey(0)


#%%
