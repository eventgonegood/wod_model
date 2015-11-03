using v23athletics.wod.priority;
using v23athletics.wod.workout;

namespace v23athletics.wod.training_planner
{
    using System;
    using System.Collections.Generic;
    using quantity;

    public class Design
    {
        public void BuildItUp()
        {
            var workout = new Workout
            {
                On = DateTime.Now,
                Name = "2015 Master's Regional WOD #4",
                Summary = "21/15/9 DL / BJ / HSPU",
                SessionDuration = TimeSpan.FromMinutes(20),
                Steps = new List<Step>
                {
                    new Step("Step 1")
                    {
                        Priority = Priorities.Time,
                        Rounds = 1,
                        Movements = new List<Movement>
                        {
                            new Movement
                            {
                                Notes = "Deadlift",
                                Name = "Deadlift",
                                Quantity = Quantity.Reps(21)
                            },
                            new Movement
                            {
                                Notes = "Box Jump",
                                Name = "Box Jump",
                                Quantity = Quantity.Reps(21)
                            },
                            new Movement
                            {
                                Notes = "Handstand Push Up",
                                Name ="HSPU",
                                Quantity = Quantity.Reps(21)
                            },
                            new Movement
                            {
                                Notes = "Deadlift",
                                Name = "Deadlift",
                                Quantity = Quantity.Reps(15)
                            },
                            new Movement
                            {
                                Notes = "Box Jump",
                                Name = "Box Jump",
                                Quantity = Quantity.Reps(15)
                            },
                            new Movement
                            {
                                Notes = "Handstand Push Up",
                                Name ="HSPU",
                                Quantity = Quantity.Reps(15)
                            },
                            new Movement
                            {
                                Notes = "Deadlift",
                                Name = "Deadlift",
                                Quantity = Quantity.Reps(9)
                            },
                            new Movement
                            {
                                Notes = "Box Jump",
                                Name = "Box Jump",
                                Quantity = Quantity.Reps(9)
                            },
                            new Movement
                            {
                                Notes = "Handstand Push Up",
                                Name ="HSPU",
                                Quantity = Quantity.Reps(9)
                            },
                        }
                    }
                }
            };
        }

        public void MultiPart()
        {
            var workout = new Workout
            {
                On = DateTime.Now,
                Name = "20150504",
                Summary = "Just Move",
                SessionDuration = TimeSpan.FromMinutes(90),
                Steps = new List<Step>
                {
                    new Step("Auxillary")
                    {
                        Rounds = 5,
                        Priority = Priorities.Task,
                        Cutoff = TimeSpan.FromMinutes(20),

                        Movements = new List<Movement>
                        {
                            new Movement
                            {
                                Name = "Wtd Ring Row",
                                Notes = "With Speed",
                                Quantity = Quantity.Reps(5),
                                Duration = TimeSpan.FromSeconds(90)
                            },
                            new Movement
                            {
                                Name = "Wtd Push Up",
                                Notes = "With Speed",
                                Quantity = Quantity.Reps(5),
                                Duration = TimeSpan.FromSeconds(90)
                            },
                        }
                    },
                    new Step("Grace")
                    {
                        Rounds = 1,
                        Priority = Priorities.Time,
                        Cutoff = TimeSpan.FromMinutes(10),
                        Movements = new List<Movement>
                        {
                            new Movement
                            {
                                Name="C&J For Time",
                                Notes = "Grace",
                                Duration = null,
                                Quantity = Quantity.Reps(30),
                                Weight = UnitsOfMeasure.Pounds(135)
                            }
                        }
                    }
                }
            };
        }

        public void Friday()
        {
            var workout = new Workout
            {
                On = DateTime.Now,
                Name = "20150508",
                Summary = "Intensity",
                SessionDuration = TimeSpan.FromMinutes(90),
                Steps = new List<Step>
                {
                    new Step("Squatz")
                    {
                        Rounds = 6,
                        Priority = Priorities.Task,
                        Cutoff = TimeSpan.FromMinutes(20),

                        Movements = new List<Movement>
                        {
                            new Movement
                            {
                                Name = "Backsquat",
                                Notes = "With Speed",
                                Quantity = Quantity.Reps(4),
                                Duration = TimeSpan.FromSeconds(90)
                            },
                        }
                    },
                    new Step("Row your face off")
                    {
                        Rounds = 5,
                        Priority = Priorities.Time,
                        Cutoff = TimeSpan.FromMinutes(10),
                        Movements = new List<Movement>
                        {
                            new Movement
                            {
                                Name="Row",
                                Notes = "Run around the cul de sac",
                                Duration = null,
                                Quantity = Quantity.Reps(25),
                                //calorie
                            },
                            new Movement
                            {
                                Name="Chest To Bar Pull Ups",
                                Notes = "Chalk up",
                                Duration = null,
                                Quantity = Quantity.Reps(50)
                            },
                            new Movement
                            {
                                Name="HSPU",
                                Notes = "",
                                Duration = null,
                                Quantity = Quantity.Reps(9)
                            }
                        }
                    }
                }
            };
        }

        public void Saturday()
        {
            var workout = new Workout
            {
                On = DateTime.Now,
                Name = "2015 Regionals Prep",
                Summary = "Strength and Intensity",
                SessionDuration = TimeSpan.FromMinutes(90),
                Steps = new List<Step>
                {
                    new Step("Step 1")
                    {
                        Rounds = 5,
                        Priority = Priorities.Task,
                        Cutoff = TimeSpan.FromMinutes(20),

                        Movements = new List<Movement>
                        {
                            new Movement
                            {
                                Name = "3 Position Clean + Jerk",
                                Notes = "Deadlift",
                                Quantity = Quantity.Reps(1),
                                Duration = TimeSpan.FromSeconds(90)
                            },
                        }
                    },
                    new Step("Step 2")
                    {
                        Rounds = 1,
                        Priority = Priorities.Time,
                        Cutoff = TimeSpan.FromMinutes(10),
                        Movements = new List<Movement>
                        {
                            new Movement
                            {
                                Name="0.5 Mile Run",
                                Notes = "Run around the cul de sac",
                                Duration = null,
                                Quantity = Quantity.Reps(1)
                            },
                            new Movement
                            {
                                Name="50 Wall Balls",
                                Notes = "To a 10ft Target",
                                Duration = null,
                                Quantity = Quantity.Reps(50)
                            }
                        }
                    }
                }
            };
        }

        public void MaxEffort()
        {
            var workout = new Workout
            {
                On = DateTime.Now,
                Name = "20150511",
                Summary = "The Hay is in the barn",
                SessionDuration = TimeSpan.FromMinutes(90),
                Steps = new List<Step>
                {
                    new Step("Technique")
                    {
                        Rounds = 1,
                        Priority = Priorities.Task,
                        Cutoff = TimeSpan.FromMinutes(20),

                        Movements = new List<Movement>
                        {
                            new Movement
                            {
                                Name = "Snatch Power Position",
                                Notes = "With Speed",
                                Quantity = Quantity.Reps(2),
                                Rounds = 2,
                                Duration = TimeSpan.FromSeconds(90)
                            },
                            new Movement
                            {
                                Name = "Snatch Knee Position",
                                Notes = "With Speed",
                                Quantity = Quantity.Reps(2),
                                Rounds = 2,
                                Duration = TimeSpan.FromSeconds(90)
                            },
                            new Movement
                            {
                                Name = "Snatch",
                                Notes = "With Speed",
                                Quantity = Quantity.Reps(2),
                                Rounds = 2,
                                Duration = TimeSpan.FromSeconds(90)
                            }
                        }
                    },
                    new Step("Burp-a-lurp")
                    {
                        Rounds = 10,
                        Priority = Priorities.Time,
                        Cutoff = TimeSpan.FromMinutes(10),
                        Movements = new List<Movement>
                        {
                            new Movement
                            {
                                Name="Burpee",
                                Notes = "Max Effort",
                                Duration = TimeSpan.FromSeconds(30),
                                Quantity = Quantity.MaxEffort,
                                Weight = UnitsOfMeasure.BodyWeight
                            },
                            new Movement
                            {
                                Name="Rest",
                                Notes = "",
                                Duration = TimeSpan.FromSeconds(30),
                                Quantity = Quantity.MaxEffort,
                                Weight = UnitsOfMeasure.BodyWeight
                            },
                            new Movement
                            {
                                Name="Dual DB Thursters",
                                Notes = "Max Effort",
                                Duration = TimeSpan.FromSeconds(30),
                                Quantity = Quantity.MaxEffort,
                                Weight = UnitsOfMeasure.BodyWeight
                            },
                            new Movement
                            {
                                Name="Rest",
                                Notes = "",
                                Duration = TimeSpan.FromSeconds(30),
                                Quantity = Quantity.MaxEffort,
                                Weight = UnitsOfMeasure.BodyWeight
                            }
                        }
                    }
                }
            };
        }
    }
}