using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lootengine.Models
{
    class Auction
    {
        public int Id{ get; set; }
        public int ItemId{ get; set; }
        public DateTime Created{ get; set; }
        public int CreatedBy{ get; set; }
        public DateTime Expires { get; set; }
        public int LastBidder { get; set; }
        public int Duration { get; set; }
        public int CurrentBid { get; set; }
        public int Buyout { get; set; }

        public Auction ()
        {

        }

        public void NewBid(int bidder, int bidAmount)
        {
            if (DateTime.Now < Expires)
            {
                if (bidder != CreatedBy)
                {
                    if (bidder != LastBidder)
                    {
                        if (bidAmount > CurrentBid)
                        {
                            CurrentBid = bidAmount;
                            LastBidder = bidder;
                        } else {
                            throw new Exception("Bid must be greater than current bid!");
                        }   
                    } else
                    {
                        throw new Exception("You already are the last bidder!");
                    }
                } else
                {
                    throw new Exception("Can't bid on your own auction");
                }
            } else
            {
                throw new Exception("Auction has already expired!");
            }

            
        }

    }
}
