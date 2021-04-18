﻿using System;

namespace Test_Fitness.BL.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    [Serializable]
    public class User
    {
        #region Свойства
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }

        public int Age { get { return DateTime.Now.Year - Birthdate.Year; } }
        #endregion

        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="n ame"> Имя. </param>
        /// <param name="gender"> Пол. </param>
        /// <param name="birthDate"> Дата рождения. </param>
        /// <param name="weight"> Вес. </param>
        /// <param name="height"> Рост. </param>
        public User(string name, Gender gender, DateTime birthDate,
                    double weight, double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или NULL.", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или NULL.", nameof(name));
            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения.", nameof(birthDate));
            }

            if (weight <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше нуля.", nameof(weight));
            }

            if (height <= 0)
            {
                throw new ArgumentException("Рост не может быть меньше нуля.", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            Birthdate = birthDate;
            Weight = weight;
            Height = height;
        }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или NULL.", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
