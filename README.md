<h1>재고를 알려줘!</h1>
<h2>프로젝트 설명</h2>
재고를 알려줘! 는 집 밖에 있는 사용자에게 재고 상황을 직접 알려줄 수 있는 수납함이다. 초음파 센서를 이용하여 수납함 각 칸의 재고 상황을 파악하여 결과를 집 안에 있는 PC를 거쳐 휴대폰으로 전달하면 사용자는 집 밖에서 집 안에 있는 재고의 상황을 관련 어플리케이션을 통해 알아볼 수 있다. 이 제품을 통해 사용자는 집 밖에 있을 때에도 구입해야할 재고의 목록을 쉽게 알 수 있다.

<h2>프로젝트 구현 내용</h2>
<h3>수납함 안의 재고 조사</h3>
● 초음파 센서를 이용하여 수납함 각 칸의 재고의 양을 확인한다.<br>
● 각 칸의 천장에 초음파 센서를 부착하여 재고의 높이를 측정하는 방식을 통해 재고의 양을 파악한다.<br>
● 파악한 재고의 양은 블루투스 통신을 통해 PC로 전송한다.<br>

<h3>수납함 안의 재고 상태 표시</h3>
● 수납장 각 칸에 붙어있는 LED를 통해 재고의 상태를 표시한다. (초록색 : 충분, 주황색 : 부족, 빨간색 : 구매 필요)<br>
● PC에서 블루투스 통신으로 수납장에서 받은 재고의 상태를 간단하게 표시한다.<br>

<h3>휴대폰에서 재고 상태 확인</h3>
● 어플리케이션이 PC로부터 재고 상태 데이터를 수신한다.<br>
● 수납장 각 칸의 재고 상태가 어떤지 색깔로 표시한다. (수납장의 LED색이랑 동일)<br>
● 수납장 각 칸이 어떤 물품인지 직접 입력할 수 있다.<br>

<h2>팀원소개</h2>
● 곽진성 (https://github.com/JinsungGwag)<br>
● 김정훈 (https://github.com/LiiNen)<br>
