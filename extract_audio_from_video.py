# extract mp3 from mp4 

import moviepy
import moviepy.editor
video = moviepy.editor.VideoFileClip(r"C:\Users\MY\Desktop\github_repos\sample.3gp") 

audio = video.audio

audio.write_audiofile(r"C:\Users\MY\Desktop\github_repos\sample.mp3")

