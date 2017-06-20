using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lootengine.Models
{
    class Auction
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Expires { get; set; }
        public int LastBidder { get; set; }
        public int Duration { get; set; }
        public int CurrentBid { get; set; }
        public int Buyout { get; set; }

        public Auction()
        {

        }

        private bool AuctionIsActive()
        {
            if (DateTime.Now < Expires)
            {
                return true;
            }
            else
            {
                throw new Exception("Auction has already expired");
            }
        }

        private bool BidderIsValid(int bidder)
        {
            if (bidder != CreatedBy)
            {
                if (bidder != LastBidder)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Bidder is already current high bid");
                }
            }
            else
            {
                throw new Exception("Bidder cannot be auction creator");
            }
        }

        public void NewBid(int bidder, int bidAmount)
        {
            if (AuctionIsActive()
            {
                if (BidderIsValid(bidder))
                {

                    if (bidAmount > CurrentBid)
                    {
                        CurrentBid = bidAmount;
                        LastBidder = bidder;
                    }
                    else
                    {
                        throw new Exception("Bid must be greater than current bid!");
                    }

                } =
            }

        }

    }
}
