namespace WinFormsBanking.views.cardBalanceView {
    public class CardBalanceState {
        public delegate void CardBalanceDelegate(float balance);
        public event CardBalanceDelegate cardBalanceEvent;

        public void ShowBalance(float balance) {
            cardBalanceEvent(balance);
        }

    }
}
