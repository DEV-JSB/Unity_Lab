using System.Collections.Generic;


public class Convention
{
    // 변수 카멜 , 파스켈 로 작성
    // private 는 카멜로 , public 은 파스켈로
    // SerializeField 는 사용하지 않음 , 해야 한다면 public 으로 그냥 작성
    
    // 0823 부로 private 변수에는 _ 를 붙이기로 하였습니다.
    // MSDN 공식에서도 private 에는 _ 를 붙이는걸 권장하고
    // 특정 상황에서 , 외부에서 Init 을 시킨다거나 할 때 같은 변수명일 경우가 많은 것 같아 _ 를 붙이겠습니다
    public int Count;
    private int _privateCount;
    public void Init(int privateCount)
    {
        _privateCount = privateCount;
    }
    
    
    // 프로퍼티는 백킹 필드로 작성
    // get , set 동시에 해야할 경우는 public 으로 그냥 작성
    // 하지만 private 로 해야하나 특정 경우에 get set 이 필요하다면 백킹 필드로 작성
    private int privateNum;

    public int PrivateNum
    {
        get => privateNum;
        set
        {
            privateNum = value;
        }
    }
    
    // 함수 또한 CamelCase 로 작성
    // 함수는 무조건 동사를 앞에 작성
    // 함수의 매개변수는 카멜 케이스로
    public void CountingNewValue(int count)
    {
        ++Count;
    }

    
    // List 나 Dictionary 를 쓸 때 굳이 dic , list 같은 건 붙이지 않는 걸로
    private List<int> players;
    private Dictionary<int, string> playerNames;
    
    // Enum 은 MS 의 공식 문서 권장에 따라 작성
    public enum AttackType
    {
        None,
        Melee,
        Ranged
    }
}
