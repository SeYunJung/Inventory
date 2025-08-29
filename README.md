# Sparta Dungeon(Inventory) Project

## 🎮 게임 소개
**『스파르타 던전(인벤토리)』**는 C#으로 구현했던 스파르타 던전 일부를 유니티로 만든 게임입니다.

Unity 엔진 기반으로 개발되었으며, ScriptableObject, Singleton을 활용하여 구현하였습니다.

- 장르: 없음 (인벤토리 기능만 구현)

- 플랫폼: PC (Windows)

- 개발 툴: Unity 2022.3.17f1, Visual Studio, GitHub

- 개발 기간: 2025.08.27 ~ 2025.08.29


## 🖼️ 게임 화면
<p>게임 플레이 화면입니다.</p>
<img src="https://github.com/user-attachments/assets/1c39a72f-0465-4ef5-829e-8331fcef8480" width="600"/>
<img src="https://github.com/user-attachments/assets/c941814f-6dd0-40ee-8367-13b3e0b323a8" width="600"/>
<img src="https://github.com/user-attachments/assets/e4d91444-cae5-4e56-ac05-aad5b1f4c63e" width="600"/>


## 🕹️ 플레이 방법

상태버튼, 인벤토리 버튼을 클릭해 플레이어 데이터가 잘 적용되었는지 확인합니다. 


## 🛠 사용 기술
- Unity 2022.3 LTS
- C# (게임 로직 및 시스템 구현)
- GitHub (버전 관리)
- TextMeshPro (UI 시스템 구성)
- ScriptableObject (아이템 데이터 관리)


## 🌟 주요 구현 기능 
 - 쉬운 접근을 위해 클래스를 Singleton으로 구현
 - ScirptableObject를 활용한 아이템 구현


## ✨ 구현 기능
1. 메인 화면 구성
- 아이디
- 레벨
- 골드
- Status 버튼 - 2. Status 보기
- Inventory 버튼 - 3. Inventory 보기

2. Status 보기
- Status 버튼, Inventory 버튼 - 사라지기
- 우측에 캐릭터 정보 표현
- 뒤로가기 버튼을 누르면 1번 화면으로 이동

3. Inventory 보기
- Status 버튼, Inventory 버튼 - 사라지기
- 우측에 인벤토리 표시
- 장착중인 아이템은 표시
- 뒤로가기 버튼을 누르면 1번 화면으로 이동


## 🧠트러블 슈팅  
<p><b>버튼이 클릭되지 않는 현상</b></p>
<p>버튼에 메서드를 연결시켜주고 게임에서 잘 적용되는지 테스트해봤는데, 버튼이 안 눌림. Raycast Target을 꺼보기도 하고, 다른 UI가 버튼 UI를 가리고 있을까 싶어서 버튼 UI만 바깥으로 빼서 테스트도 해봤지만, 여전히 버튼이 안 눌림.</p>
<p><b>원인</b></p>
<p>버튼 이미지를 좌우 반전시켜주고 싶어서, 버튼 UI의 Rotation y값을 180으로 설정했다. 근데 Rotation y값을 180으로 설정하면 버튼이 뒤집어진다. 버튼은 앞면을 기준으로 클릭처리를 해주는데 내가 뒤집어 놓았으니 클릭처리가 안 되었던 것.</p>
<p><b>해결</b></p>
<p>버튼 UI의 Rotation y값을 0으로 설정해줬더니, 버튼이 눌려진다.</p>

## 😊 프로젝트 회고
<p>아이템 데이터를 좀 이상하게 관리한 것 같다. 나중에 수정할 시간이 있으면 수정해야 겠다.</p>
