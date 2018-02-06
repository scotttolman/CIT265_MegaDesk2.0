using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_scotttolman
{
    public class DeskQuote
    {
        public const float BASE_PRICE = 200;
        public const float OVERSIZE = 1000;
        public const float OVERSIZE_COST = 1;
        public const float DRAWER_COST = 50;
        public const float OAK_COST = 200;
        public const float LAMINATE_COST = 100;
        public const float PINE_COST = 50;
        public const float ROSEWOOD_COST = 300;
        public const float VENEER_COST = 125;
        public const float RUSH03 = 60;
        public const float RUSH05 = 40;
        public const float RUSH07 = 30;
        public const float RUSH13 = 70;
        public const float RUSH15 = 50;
        public const float RUSH17 = 35;
        public const float RUSH23 = 80;
        public const float RUSH25 = 60;
        public const float RUSH27 = 40;

        Desk deskObject;
        string firstName;
        string lastName;
        float oversize;
        float oversizeCost;
        float drawerCost;
        float surfaceCost;
        int rush;
        float rushCost = 0;
        float totalCost;

        public DeskQuote(string firstName, string lastName, Desk _deskObject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            deskObject = _deskObject;
            oversize = OVERSIZE - (deskObject.getDepth() * deskObject.getWidth());
            oversizeCost = calcOversizeCost();
            drawerCost = calcDrawerCost();
            surfaceCost = calcSurfaceCost();
            totalCost = calcTotalCost();
        }

        public string getFirst() { return firstName; }

        public string getLast() { return lastName; }

        public int getRush() { return rush; }

        // only optional field setter
        public void addRush(int days)
        {
            rush = days;
            rushCost = calcRushCost();
            calcTotalCost();
        }

        public float calcOversizeCost()
        {
            float oversize = ((OVERSIZE - (deskObject.getDepth() * deskObject.getWidth())) * OVERSIZE_COST);
            if (oversize > 0)
                return oversize;
            else
                return 0;
        }

        public float calcDrawerCost()
        {
            float cost = (deskObject.getDrawers() * DRAWER_COST);
            return cost;
        }

        public float calcSurfaceCost()
        {
            switch ((int)deskObject.getSurface())
            {
                case 0:
                    return OAK_COST;
                case 1:
                    return LAMINATE_COST;
                case 2:
                    return PINE_COST;
                case 3:
                    return ROSEWOOD_COST;
                case 4:
                    return VENEER_COST;
                default:
                    return -9999999; // find errors with from negative cost
            }
        }

        public float calcTotalCost()
        {
            float cost = BASE_PRICE + oversizeCost + drawerCost + surfaceCost + rushCost;
            return cost;
        }

        public float calcRushCost()
        {
            float cost = 0;
            if (oversize < 1000)
            {
                if (rush == 3)
                    cost = RUSH03;
                else if (rush == 5)
                        cost = RUSH05;
                else if (rush == 7)
                        cost = RUSH07;
            }
            else if (oversize >= 1000 && oversize <= 2000)
            {
                if (rush == 3)
                    cost = RUSH13;
                else if (rush == 5)
                    cost = RUSH15;
                else if (rush == 7)
                    cost = RUSH17;
            }
            else
            {
                if (rush == 3)
                    cost = RUSH23;
                else if (rush == 5)
                    cost = RUSH25;
                else if (rush == 7)
                    cost = RUSH27;
            }
            return cost;
        }
    }
}
