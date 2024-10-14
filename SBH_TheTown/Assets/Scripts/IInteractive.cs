using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//상호작용이 가능한 스크립트에 붙는 인터페이스
public interface IInteractive
{
    //상호작용 함수 -> UI 활성화, 특수 기믹 등등
    public void InteracteAction() { }
}
