import tkinter as tk

def button_clicked():
    print("clicked")

root = tk.Tk()

um = tk.Button(root, text="1", command=button_clicked)
um.pack()

zero = tk.Button(root, text="0", command=button_clicked)
zero.pack()

enter = tk.Button(root, text="Enter", command=button_clicked)
enter.pack()

root.mainloop()