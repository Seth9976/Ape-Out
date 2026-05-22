using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x0200012E RID: 302
	public class Menu : MonoBehaviour
	{
		// Token: 0x060025A4 RID: 9636 RVA: 0x0009CBF0 File Offset: 0x0009ADF0
		// Note: this type is marked as 'beforefieldinit'.
		static Menu()
		{
			Il2CppClassPointerStore<Menu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Menu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Menu>.NativeClassPtr);
			Menu.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "paused");
			Menu.NativeFieldInfoPtr_pauseMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "pauseMenu");
			Menu.NativeFieldInfoPtr_optionsMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "optionsMenu");
			Menu.NativeFieldInfoPtr_startgo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "startgo");
			Menu.NativeFieldInfoPtr_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "free");
			Menu.NativeFieldInfoPtr_retrying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "retrying");
			Menu.NativeFieldInfoPtr_lineMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "lineMat");
			Menu.NativeFieldInfoPtr_wallMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "wallMat");
			Menu.NativeFieldInfoPtr_select = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "select");
			Menu.NativeFieldInfoPtr_prevStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "prevStick");
			Menu.NativeFieldInfoPtr_selectCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "selectCol");
			Menu.NativeFieldInfoPtr_unselectCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "unselectCol");
			Menu.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "button");
			Menu.NativeFieldInfoPtr_buttonIndexToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "buttonIndexToDisable");
			Menu.NativeFieldInfoPtr_lastStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "lastStick");
			Menu.NativeFieldInfoPtr_acceptInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "acceptInput");
			Menu.NativeFieldInfoPtr_enterInitScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "enterInitScreen");
			Menu.NativeFieldInfoPtr_enteringInits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "enteringInits");
			Menu.NativeFieldInfoPtr_initText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "initText");
			Menu.NativeFieldInfoPtr_prevLStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "prevLStick");
			Menu.NativeFieldInfoPtr_curLetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "curLetter");
			Menu.NativeFieldInfoPtr_confirmedInits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "confirmedInits");
			Menu.NativeFieldInfoPtr_rTrig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "rTrig");
			Menu.NativeFieldInfoPtr_prevRTrig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "prevRTrig");
			Menu.NativeFieldInfoPtr_cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "cursor");
			Menu.NativeFieldInfoPtr_prevMousePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "prevMousePos");
			Menu.NativeFieldInfoPtr_startedLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "startedLoad");
			Menu.NativeFieldInfoPtr_asyncLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "asyncLoader");
			Menu.NativeFieldInfoPtr_keyboarding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "keyboarding");
			Menu.NativeFieldInfoPtr_pageOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "pageOffset");
			Menu.NativeFieldInfoPtr_pageMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "pageMaterial");
			Menu.NativeFieldInfoPtr_mainTexString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "mainTexString");
			Menu.NativeFieldInfoPtr_pageTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "pageTimer");
			Menu.NativeFieldInfoPtr_panelDad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "panelDad");
			Menu.NativeFieldInfoPtr_gotOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "gotOffset");
			Menu.NativeFieldInfoPtr_buttonMenuIndexMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "buttonMenuIndexMax");
			Menu.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "controller");
			Menu.NativeFieldInfoPtr_perfectSticker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "perfectSticker");
			Menu.NativeFieldInfoPtr_pacifismSticker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "pacifismSticker");
			Menu.NativeFieldInfoPtr_hasWon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "hasWon");
			Menu.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666274);
			Menu.NativeMethodInfoPtr_GrimePage_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666275);
			Menu.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666276);
			Menu.NativeMethodInfoPtr_PressedAButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666277);
			Menu.NativeMethodInfoPtr_PlayStick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666278);
			Menu.NativeMethodInfoPtr_PauseDeal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666279);
			Menu.NativeMethodInfoPtr_Bullshit_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666280);
			Menu.NativeMethodInfoPtr_Retry_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666281);
			Menu.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666282);
			Menu.NativeMethodInfoPtr_Quit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666283);
			Menu.NativeMethodInfoPtr_Fullscreen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666284);
			Menu.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666285);
			Menu.NativeMethodInfoPtr_GetOffset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666286);
			Menu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100666287);
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x0009D058 File Offset: 0x0009B258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73749, XrefRangeEnd = 73777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x0009D08C File Offset: 0x0009B28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73777, XrefRangeEnd = 73780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GrimePage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_GrimePage_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x0009D0CC File Offset: 0x0009B2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73780, XrefRangeEnd = 73817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x0009D100 File Offset: 0x0009B300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73822, RefRangeEnd = 73823, XrefRangeStart = 73817, XrefRangeEnd = 73822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PressedAButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_PressedAButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0009D13C File Offset: 0x0009B33C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 73831, RefRangeEnd = 73834, XrefRangeStart = 73823, XrefRangeEnd = 73831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayStick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_PlayStick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x0009D170 File Offset: 0x0009B370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74017, RefRangeEnd = 74018, XrefRangeStart = 73834, XrefRangeEnd = 74017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PauseDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_PauseDeal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x0009D1A4 File Offset: 0x0009B3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74018, XrefRangeEnd = 74021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Bullshit(float blamo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref blamo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_Bullshit_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x0009D1F0 File Offset: 0x0009B3F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74024, RefRangeEnd = 74026, XrefRangeStart = 74021, XrefRangeEnd = 74024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Retry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_Retry_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x0009D230 File Offset: 0x0009B430
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74065, RefRangeEnd = 74069, XrefRangeStart = 74026, XrefRangeEnd = 74065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x0009D264 File Offset: 0x0009B464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Quit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_Quit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x0009D298 File Offset: 0x0009B498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74069, XrefRangeEnd = 74077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fullscreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_Fullscreen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x0009D2CC File Offset: 0x0009B4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74077, XrefRangeEnd = 74086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x0009D300 File Offset: 0x0009B500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74127, RefRangeEnd = 74128, XrefRangeStart = 74086, XrefRangeEnd = 74127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_GetOffset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x0009D334 File Offset: 0x0009B534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Menu()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Menu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x0001A61A File Offset: 0x0001881A
		public Menu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x0009D370 File Offset: 0x0009B570
		// (set) Token: 0x060025B5 RID: 9653 RVA: 0x0001A623 File Offset: 0x00018823
		public unsafe bool paused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_paused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_paused)) = value;
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x060025B6 RID: 9654 RVA: 0x0009D398 File Offset: 0x0009B598
		// (set) Token: 0x060025B7 RID: 9655 RVA: 0x0001A63E File Offset: 0x0001883E
		public unsafe GameObject pauseMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_pauseMenu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_pauseMenu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x0009D3C8 File Offset: 0x0009B5C8
		// (set) Token: 0x060025B9 RID: 9657 RVA: 0x0001A65D File Offset: 0x0001885D
		public unsafe GameObject optionsMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_optionsMenu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_optionsMenu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x0009D3F8 File Offset: 0x0009B5F8
		// (set) Token: 0x060025BB RID: 9659 RVA: 0x0001A67C File Offset: 0x0001887C
		public unsafe bool startgo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_startgo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_startgo)) = value;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x0009D420 File Offset: 0x0009B620
		// (set) Token: 0x060025BD RID: 9661 RVA: 0x0001A697 File Offset: 0x00018897
		public unsafe bool free
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_free);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_free)) = value;
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x0009D448 File Offset: 0x0009B648
		// (set) Token: 0x060025BF RID: 9663 RVA: 0x0001A6B2 File Offset: 0x000188B2
		public unsafe bool retrying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_retrying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_retrying)) = value;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x0009D470 File Offset: 0x0009B670
		// (set) Token: 0x060025C1 RID: 9665 RVA: 0x0001A6CD File Offset: 0x000188CD
		public unsafe Material lineMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_lineMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_lineMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x060025C2 RID: 9666 RVA: 0x0009D4A0 File Offset: 0x0009B6A0
		// (set) Token: 0x060025C3 RID: 9667 RVA: 0x0001A6EC File Offset: 0x000188EC
		public unsafe Material wallMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_wallMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_wallMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x060025C4 RID: 9668 RVA: 0x0009D4D0 File Offset: 0x0009B6D0
		// (set) Token: 0x060025C5 RID: 9669 RVA: 0x0001A70B File Offset: 0x0001890B
		public unsafe int select
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_select);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_select)) = value;
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x060025C6 RID: 9670 RVA: 0x0009D4F8 File Offset: 0x0009B6F8
		// (set) Token: 0x060025C7 RID: 9671 RVA: 0x0001A726 File Offset: 0x00018926
		public unsafe float prevStick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_prevStick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_prevStick)) = value;
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x0009D520 File Offset: 0x0009B720
		// (set) Token: 0x060025C9 RID: 9673 RVA: 0x0001A741 File Offset: 0x00018941
		public unsafe Color selectCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_selectCol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_selectCol)) = value;
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x0009D548 File Offset: 0x0009B748
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x0001A75C File Offset: 0x0001895C
		public unsafe Color unselectCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_unselectCol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_unselectCol)) = value;
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x0009D570 File Offset: 0x0009B770
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x0001A777 File Offset: 0x00018977
		public unsafe Il2CppReferenceArray<Text> button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x0009D5A0 File Offset: 0x0009B7A0
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x0001A796 File Offset: 0x00018996
		public unsafe Il2CppStructArray<bool> buttonIndexToDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_buttonIndexToDisable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_buttonIndexToDisable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x0009D5D0 File Offset: 0x0009B7D0
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x0001A7B5 File Offset: 0x000189B5
		public unsafe int lastStick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_lastStick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_lastStick)) = value;
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x0009D5F8 File Offset: 0x0009B7F8
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x0001A7D0 File Offset: 0x000189D0
		public unsafe bool acceptInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_acceptInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_acceptInput)) = value;
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x0009D620 File Offset: 0x0009B820
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x0001A7EB File Offset: 0x000189EB
		public unsafe bool enterInitScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_enterInitScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_enterInitScreen)) = value;
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x0009D648 File Offset: 0x0009B848
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x0001A806 File Offset: 0x00018A06
		public unsafe bool enteringInits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_enteringInits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_enteringInits)) = value;
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x0009D670 File Offset: 0x0009B870
		// (set) Token: 0x060025D9 RID: 9689 RVA: 0x0001A821 File Offset: 0x00018A21
		public unsafe Text initText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_initText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_initText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x0009D6A0 File Offset: 0x0009B8A0
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x0001A840 File Offset: 0x00018A40
		public unsafe Vector2 prevLStick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_prevLStick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_prevLStick)) = value;
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x0009D6C8 File Offset: 0x0009B8C8
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x0001A85B File Offset: 0x00018A5B
		public unsafe int curLetter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_curLetter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_curLetter)) = value;
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x0009D6F0 File Offset: 0x0009B8F0
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x0001A876 File Offset: 0x00018A76
		public unsafe string confirmedInits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_confirmedInits);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_confirmedInits), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x0009D718 File Offset: 0x0009B918
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x0001A895 File Offset: 0x00018A95
		public unsafe float rTrig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_rTrig);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_rTrig)) = value;
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x0009D740 File Offset: 0x0009B940
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x0001A8B0 File Offset: 0x00018AB0
		public unsafe float prevRTrig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_prevRTrig);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_prevRTrig)) = value;
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x0009D768 File Offset: 0x0009B968
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x0001A8CB File Offset: 0x00018ACB
		public unsafe GameObject cursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_cursor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_cursor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x0009D798 File Offset: 0x0009B998
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x0001A8EA File Offset: 0x00018AEA
		public unsafe Vector2 prevMousePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_prevMousePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_prevMousePos)) = value;
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x0009D7C0 File Offset: 0x0009B9C0
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x0001A905 File Offset: 0x00018B05
		public unsafe bool startedLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_startedLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_startedLoad)) = value;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x0009D7E8 File Offset: 0x0009B9E8
		// (set) Token: 0x060025EB RID: 9707 RVA: 0x0001A920 File Offset: 0x00018B20
		public unsafe AsyncOperation asyncLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_asyncLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_asyncLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x0009D818 File Offset: 0x0009BA18
		// (set) Token: 0x060025ED RID: 9709 RVA: 0x0001A93F File Offset: 0x00018B3F
		public unsafe bool keyboarding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_keyboarding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_keyboarding)) = value;
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x0009D840 File Offset: 0x0009BA40
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x0001A95A File Offset: 0x00018B5A
		public unsafe Vector2 pageOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_pageOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_pageOffset)) = value;
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x0009D868 File Offset: 0x0009BA68
		// (set) Token: 0x060025F1 RID: 9713 RVA: 0x0001A975 File Offset: 0x00018B75
		public unsafe Material pageMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_pageMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_pageMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x0009D898 File Offset: 0x0009BA98
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x0001A994 File Offset: 0x00018B94
		public unsafe string mainTexString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_mainTexString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_mainTexString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x0009D8C0 File Offset: 0x0009BAC0
		// (set) Token: 0x060025F5 RID: 9717 RVA: 0x0001A9B3 File Offset: 0x00018BB3
		public unsafe float pageTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_pageTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_pageTimer)) = value;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x0009D8E8 File Offset: 0x0009BAE8
		// (set) Token: 0x060025F7 RID: 9719 RVA: 0x0001A9CE File Offset: 0x00018BCE
		public unsafe Transform panelDad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_panelDad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_panelDad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x0009D918 File Offset: 0x0009BB18
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x0001A9ED File Offset: 0x00018BED
		public unsafe bool gotOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_gotOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_gotOffset)) = value;
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x0009D940 File Offset: 0x0009BB40
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x0001AA08 File Offset: 0x00018C08
		public unsafe int buttonMenuIndexMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_buttonMenuIndexMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_buttonMenuIndexMax)) = value;
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x0009D968 File Offset: 0x0009BB68
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x0001AA23 File Offset: 0x00018C23
		public unsafe Player controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x0009D998 File Offset: 0x0009BB98
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x0001AA42 File Offset: 0x00018C42
		public unsafe GameObject perfectSticker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_perfectSticker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_perfectSticker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x0009D9C8 File Offset: 0x0009BBC8
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x0001AA61 File Offset: 0x00018C61
		public unsafe GameObject pacifismSticker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_pacifismSticker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_pacifismSticker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x0009D9F8 File Offset: 0x0009BBF8
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x0001AA80 File Offset: 0x00018C80
		public unsafe bool hasWon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_hasWon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_hasWon)) = value;
			}
		}

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeFieldInfoPtr_paused;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeFieldInfoPtr_pauseMenu;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeFieldInfoPtr_optionsMenu;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeFieldInfoPtr_startgo;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeFieldInfoPtr_free;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeFieldInfoPtr_retrying;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeFieldInfoPtr_lineMat;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeFieldInfoPtr_wallMat;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeFieldInfoPtr_select;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeFieldInfoPtr_prevStick;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeFieldInfoPtr_selectCol;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeFieldInfoPtr_unselectCol;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeFieldInfoPtr_buttonIndexToDisable;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeFieldInfoPtr_lastStick;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeFieldInfoPtr_acceptInput;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeFieldInfoPtr_enterInitScreen;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeFieldInfoPtr_enteringInits;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeFieldInfoPtr_initText;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeFieldInfoPtr_prevLStick;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeFieldInfoPtr_curLetter;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeFieldInfoPtr_confirmedInits;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeFieldInfoPtr_rTrig;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeFieldInfoPtr_prevRTrig;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeFieldInfoPtr_cursor;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeFieldInfoPtr_prevMousePos;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeFieldInfoPtr_startedLoad;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeFieldInfoPtr_asyncLoader;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeFieldInfoPtr_keyboarding;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeFieldInfoPtr_pageOffset;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeFieldInfoPtr_pageMaterial;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeFieldInfoPtr_mainTexString;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeFieldInfoPtr_pageTimer;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeFieldInfoPtr_panelDad;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeFieldInfoPtr_gotOffset;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeFieldInfoPtr_buttonMenuIndexMax;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeFieldInfoPtr_perfectSticker;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeFieldInfoPtr_pacifismSticker;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeFieldInfoPtr_hasWon;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr_GrimePage_Private_IEnumerator_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeMethodInfoPtr_PressedAButton_Public_Boolean_0;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeMethodInfoPtr_PlayStick_Public_Void_0;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeMethodInfoPtr_PauseDeal_Public_Void_0;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeMethodInfoPtr_Bullshit_Private_IEnumerator_Single_0;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeMethodInfoPtr_Retry_Public_IEnumerator_0;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Void_0;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr_Fullscreen_Public_Void_0;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_GetOffset_Public_Void_0;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000330 RID: 816
		[ObfuscatedName("Menu+<GrimePage>d__41")]
		public sealed class _GrimePage_d__41 : global::Il2CppSystem.Object
		{
			// Token: 0x0600517D RID: 20861 RVA: 0x00128E58 File Offset: 0x00127058
			// Note: this type is marked as 'beforefieldinit'.
			static _GrimePage_d__41()
			{
				Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Menu>.NativeClassPtr, "<GrimePage>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr);
				Menu._GrimePage_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr, "<>1__state");
				Menu._GrimePage_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr, "<>2__current");
				Menu._GrimePage_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr, "<>4__this");
				Menu._GrimePage_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr, 100666288);
				Menu._GrimePage_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr, 100666289);
				Menu._GrimePage_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr, 100666290);
				Menu._GrimePage_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr, 100666291);
				Menu._GrimePage_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr, 100666292);
				Menu._GrimePage_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr, 100666293);
			}

			// Token: 0x0600517E RID: 20862 RVA: 0x00128F38 File Offset: 0x00127138
			[CallerCount(0)]
			public unsafe _GrimePage_d__41(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Menu._GrimePage_d__41>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._GrimePage_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600517F RID: 20863 RVA: 0x00128F80 File Offset: 0x00127180
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._GrimePage_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005180 RID: 20864 RVA: 0x00128FB4 File Offset: 0x001271B4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._GrimePage_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DB9 RID: 7609
			// (get) Token: 0x06005181 RID: 20865 RVA: 0x00128FF0 File Offset: 0x001271F0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._GrimePage_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005182 RID: 20866 RVA: 0x00129030 File Offset: 0x00127230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73561, XrefRangeEnd = 73566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._GrimePage_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DBA RID: 7610
			// (get) Token: 0x06005183 RID: 20867 RVA: 0x00129064 File Offset: 0x00127264
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._GrimePage_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005184 RID: 20868 RVA: 0x0002F77F File Offset: 0x0002D97F
			public _GrimePage_d__41(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001DB6 RID: 7606
			// (get) Token: 0x06005185 RID: 20869 RVA: 0x001290A4 File Offset: 0x001272A4
			// (set) Token: 0x06005186 RID: 20870 RVA: 0x0002F788 File Offset: 0x0002D988
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._GrimePage_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._GrimePage_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DB7 RID: 7607
			// (get) Token: 0x06005187 RID: 20871 RVA: 0x001290CC File Offset: 0x001272CC
			// (set) Token: 0x06005188 RID: 20872 RVA: 0x0002F7A3 File Offset: 0x0002D9A3
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._GrimePage_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._GrimePage_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DB8 RID: 7608
			// (get) Token: 0x06005189 RID: 20873 RVA: 0x001290FC File Offset: 0x001272FC
			// (set) Token: 0x0600518A RID: 20874 RVA: 0x0002F7C2 File Offset: 0x0002D9C2
			public unsafe Menu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._GrimePage_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Menu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._GrimePage_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040035ED RID: 13805
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040035EE RID: 13806
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040035EF RID: 13807
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040035F0 RID: 13808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040035F1 RID: 13809
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035F2 RID: 13810
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040035F3 RID: 13811
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040035F4 RID: 13812
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035F5 RID: 13813
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000331 RID: 817
		[ObfuscatedName("Menu+<Bullshit>d__46")]
		public sealed class _Bullshit_d__46 : global::Il2CppSystem.Object
		{
			// Token: 0x0600518B RID: 20875 RVA: 0x0012912C File Offset: 0x0012732C
			// Note: this type is marked as 'beforefieldinit'.
			static _Bullshit_d__46()
			{
				Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Menu>.NativeClassPtr, "<Bullshit>d__46");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr);
				Menu._Bullshit_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr, "<>1__state");
				Menu._Bullshit_d__46.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr, "<>2__current");
				Menu._Bullshit_d__46.NativeFieldInfoPtr_blamo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr, "blamo");
				Menu._Bullshit_d__46.NativeFieldInfoPtr__tim_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr, "<tim>5__2");
				Menu._Bullshit_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr, 100666294);
				Menu._Bullshit_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr, 100666295);
				Menu._Bullshit_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr, 100666296);
				Menu._Bullshit_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr, 100666297);
				Menu._Bullshit_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr, 100666298);
				Menu._Bullshit_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr, 100666299);
			}

			// Token: 0x0600518C RID: 20876 RVA: 0x00129220 File Offset: 0x00127420
			[CallerCount(0)]
			public unsafe _Bullshit_d__46(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Menu._Bullshit_d__46>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Bullshit_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600518D RID: 20877 RVA: 0x00129268 File Offset: 0x00127468
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Bullshit_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600518E RID: 20878 RVA: 0x0012929C File Offset: 0x0012749C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Bullshit_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DBF RID: 7615
			// (get) Token: 0x0600518F RID: 20879 RVA: 0x001292D8 File Offset: 0x001274D8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Bullshit_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005190 RID: 20880 RVA: 0x00129318 File Offset: 0x00127518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73566, XrefRangeEnd = 73571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Bullshit_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DC0 RID: 7616
			// (get) Token: 0x06005191 RID: 20881 RVA: 0x0012934C File Offset: 0x0012754C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Bullshit_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005192 RID: 20882 RVA: 0x0002F7E1 File Offset: 0x0002D9E1
			public _Bullshit_d__46(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001DBB RID: 7611
			// (get) Token: 0x06005193 RID: 20883 RVA: 0x0012938C File Offset: 0x0012758C
			// (set) Token: 0x06005194 RID: 20884 RVA: 0x0002F7EA File Offset: 0x0002D9EA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Bullshit_d__46.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Bullshit_d__46.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DBC RID: 7612
			// (get) Token: 0x06005195 RID: 20885 RVA: 0x001293B4 File Offset: 0x001275B4
			// (set) Token: 0x06005196 RID: 20886 RVA: 0x0002F805 File Offset: 0x0002DA05
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Bullshit_d__46.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Bullshit_d__46.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DBD RID: 7613
			// (get) Token: 0x06005197 RID: 20887 RVA: 0x001293E4 File Offset: 0x001275E4
			// (set) Token: 0x06005198 RID: 20888 RVA: 0x0002F824 File Offset: 0x0002DA24
			public unsafe float blamo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Bullshit_d__46.NativeFieldInfoPtr_blamo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Bullshit_d__46.NativeFieldInfoPtr_blamo)) = value;
				}
			}

			// Token: 0x17001DBE RID: 7614
			// (get) Token: 0x06005199 RID: 20889 RVA: 0x0012940C File Offset: 0x0012760C
			// (set) Token: 0x0600519A RID: 20890 RVA: 0x0002F83F File Offset: 0x0002DA3F
			public unsafe float _tim_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Bullshit_d__46.NativeFieldInfoPtr__tim_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Bullshit_d__46.NativeFieldInfoPtr__tim_5__2)) = value;
				}
			}

			// Token: 0x040035F6 RID: 13814
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040035F7 RID: 13815
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040035F8 RID: 13816
			private static readonly IntPtr NativeFieldInfoPtr_blamo;

			// Token: 0x040035F9 RID: 13817
			private static readonly IntPtr NativeFieldInfoPtr__tim_5__2;

			// Token: 0x040035FA RID: 13818
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040035FB RID: 13819
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035FC RID: 13820
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040035FD RID: 13821
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040035FE RID: 13822
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035FF RID: 13823
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000332 RID: 818
		[ObfuscatedName("Menu+<Retry>d__47")]
		public sealed class _Retry_d__47 : global::Il2CppSystem.Object
		{
			// Token: 0x0600519B RID: 20891 RVA: 0x00129434 File Offset: 0x00127634
			// Note: this type is marked as 'beforefieldinit'.
			static _Retry_d__47()
			{
				Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Menu>.NativeClassPtr, "<Retry>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr);
				Menu._Retry_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr, "<>1__state");
				Menu._Retry_d__47.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr, "<>2__current");
				Menu._Retry_d__47.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr, "<>4__this");
				Menu._Retry_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr, 100666300);
				Menu._Retry_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr, 100666301);
				Menu._Retry_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr, 100666302);
				Menu._Retry_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr, 100666303);
				Menu._Retry_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr, 100666304);
				Menu._Retry_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr, 100666305);
			}

			// Token: 0x0600519C RID: 20892 RVA: 0x00129514 File Offset: 0x00127714
			[CallerCount(0)]
			public unsafe _Retry_d__47(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Menu._Retry_d__47>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Retry_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600519D RID: 20893 RVA: 0x0012955C File Offset: 0x0012775C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Retry_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600519E RID: 20894 RVA: 0x00129590 File Offset: 0x00127790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73571, XrefRangeEnd = 73744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Retry_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DC4 RID: 7620
			// (get) Token: 0x0600519F RID: 20895 RVA: 0x001295CC File Offset: 0x001277CC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Retry_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060051A0 RID: 20896 RVA: 0x0012960C File Offset: 0x0012780C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73744, XrefRangeEnd = 73749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Retry_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DC5 RID: 7621
			// (get) Token: 0x060051A1 RID: 20897 RVA: 0x00129640 File Offset: 0x00127840
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Menu._Retry_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060051A2 RID: 20898 RVA: 0x0002F85A File Offset: 0x0002DA5A
			public _Retry_d__47(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001DC1 RID: 7617
			// (get) Token: 0x060051A3 RID: 20899 RVA: 0x00129680 File Offset: 0x00127880
			// (set) Token: 0x060051A4 RID: 20900 RVA: 0x0002F863 File Offset: 0x0002DA63
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Retry_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Retry_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DC2 RID: 7618
			// (get) Token: 0x060051A5 RID: 20901 RVA: 0x001296A8 File Offset: 0x001278A8
			// (set) Token: 0x060051A6 RID: 20902 RVA: 0x0002F87E File Offset: 0x0002DA7E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Retry_d__47.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Retry_d__47.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DC3 RID: 7619
			// (get) Token: 0x060051A7 RID: 20903 RVA: 0x001296D8 File Offset: 0x001278D8
			// (set) Token: 0x060051A8 RID: 20904 RVA: 0x0002F89D File Offset: 0x0002DA9D
			public unsafe Menu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Retry_d__47.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Menu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Menu._Retry_d__47.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003600 RID: 13824
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003601 RID: 13825
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003602 RID: 13826
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003603 RID: 13827
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003604 RID: 13828
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003605 RID: 13829
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003606 RID: 13830
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003607 RID: 13831
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003608 RID: 13832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
