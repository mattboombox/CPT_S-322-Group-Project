namespace RoomateFinderEngne
{
    public class SurveyHub
    {
        private const int TOTAL_SURVEYS = 3;

        //Class responsible for connecting the controller with the rest of the surveys
        public int completedSurveyNum; //Counter used as guard before progressing to grading state
        
        public SurveyHub()
        {
            completedSurveyNum = 0;
        }

        public bool verifySurveyNum()
        {
            if(this.completedSurveyNum != TOTAL_SURVEYS)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void increaseSurveyNum()
        {
            this.verifySurveyNum++;
        }

        //WIP
        public void launchPersonalSurvey()
        {
            //Creation of personalSurvey object
        }
        
        public void launchDromSurvey()
        {
            //Creation of dormSurvey object
        }

        public void launchRoommateSurvey()
        {
            //Creation of roommateSurvey object
        }

        public void launchGradingPhase()
        {
            //Proceed to the roommate grading phase of the app
            //Requires all three surveys to have been completed

            if(this.verifySurveyNum())
            {
                //Creation of roommateGrading object
            }
            else
            {
                //Display message to user to complete unfinished surveys
            }
        }
    }
}