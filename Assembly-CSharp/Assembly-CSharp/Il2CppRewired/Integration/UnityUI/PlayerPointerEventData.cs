using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.UI;
using UnityEngine.EventSystems;

namespace Il2CppRewired.Integration.UnityUI
{
	// Token: 0x020001E8 RID: 488
	public class PlayerPointerEventData : PointerEventData
	{
		// Token: 0x06003915 RID: 14613 RVA: 0x000D4F5C File Offset: 0x000D315C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPointerEventData()
		{
			Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", "PlayerPointerEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr);
			PlayerPointerEventData.NativeFieldInfoPtr__playerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<playerId>k__BackingField");
			PlayerPointerEventData.NativeFieldInfoPtr__inputSourceIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<inputSourceIndex>k__BackingField");
			PlayerPointerEventData.NativeFieldInfoPtr__mouseSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<mouseSource>k__BackingField");
			PlayerPointerEventData.NativeFieldInfoPtr__touchSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<touchSource>k__BackingField");
			PlayerPointerEventData.NativeFieldInfoPtr__sourceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<sourceType>k__BackingField");
			PlayerPointerEventData.NativeFieldInfoPtr__buttonIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<buttonIndex>k__BackingField");
			PlayerPointerEventData.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668054);
			PlayerPointerEventData.NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668055);
			PlayerPointerEventData.NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668056);
			PlayerPointerEventData.NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668057);
			PlayerPointerEventData.NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668058);
			PlayerPointerEventData.NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668059);
			PlayerPointerEventData.NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668060);
			PlayerPointerEventData.NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668061);
			PlayerPointerEventData.NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668062);
			PlayerPointerEventData.NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668063);
			PlayerPointerEventData.NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668064);
			PlayerPointerEventData.NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668065);
			PlayerPointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668066);
			PlayerPointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668067);
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06003916 RID: 14614 RVA: 0x000D511C File Offset: 0x000D331C
		// (set) Token: 0x06003917 RID: 14615 RVA: 0x000D5158 File Offset: 0x000D3358
		public unsafe int playerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06003918 RID: 14616 RVA: 0x000D5198 File Offset: 0x000D3398
		// (set) Token: 0x06003919 RID: 14617 RVA: 0x000D51D4 File Offset: 0x000D33D4
		public unsafe int inputSourceIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x0600391A RID: 14618 RVA: 0x000D5214 File Offset: 0x000D3414
		// (set) Token: 0x0600391B RID: 14619 RVA: 0x000D5254 File Offset: 0x000D3454
		public unsafe IMouseInputSource mouseSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMouseInputSource>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x0600391C RID: 14620 RVA: 0x000D5298 File Offset: 0x000D3498
		// (set) Token: 0x0600391D RID: 14621 RVA: 0x000D52D8 File Offset: 0x000D34D8
		public unsafe ITouchInputSource touchSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITouchInputSource>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88785, RefRangeEnd = 88786, XrefRangeStart = 88785, XrefRangeEnd = 88785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x000D531C File Offset: 0x000D351C
		// (set) Token: 0x0600391F RID: 14623 RVA: 0x000D5358 File Offset: 0x000D3558
		public unsafe PointerEventType sourceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06003920 RID: 14624 RVA: 0x000D5398 File Offset: 0x000D3598
		// (set) Token: 0x06003921 RID: 14625 RVA: 0x000D53D4 File Offset: 0x000D35D4
		public unsafe int buttonIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x000D5414 File Offset: 0x000D3614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88786, XrefRangeEnd = 88787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPointerEventData(EventSystem eventSystem)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x000D5460 File Offset: 0x000D3660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88787, XrefRangeEnd = 88843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerPointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x00024603 File Offset: 0x00022803
		public PlayerPointerEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06003925 RID: 14629 RVA: 0x000D54A4 File Offset: 0x000D36A4
		// (set) Token: 0x06003926 RID: 14630 RVA: 0x0002460C File Offset: 0x0002280C
		public unsafe int _playerId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__playerId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__playerId_k__BackingField)) = value;
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x000D54CC File Offset: 0x000D36CC
		// (set) Token: 0x06003928 RID: 14632 RVA: 0x00024627 File Offset: 0x00022827
		public unsafe int _inputSourceIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__inputSourceIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__inputSourceIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06003929 RID: 14633 RVA: 0x000D54F4 File Offset: 0x000D36F4
		// (set) Token: 0x0600392A RID: 14634 RVA: 0x00024642 File Offset: 0x00022842
		public unsafe IMouseInputSource _mouseSource_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__mouseSource_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMouseInputSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__mouseSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x000D5524 File Offset: 0x000D3724
		// (set) Token: 0x0600392C RID: 14636 RVA: 0x00024661 File Offset: 0x00022861
		public unsafe ITouchInputSource _touchSource_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__touchSource_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITouchInputSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__touchSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x0600392D RID: 14637 RVA: 0x000D5554 File Offset: 0x000D3754
		// (set) Token: 0x0600392E RID: 14638 RVA: 0x00024680 File Offset: 0x00022880
		public unsafe PointerEventType _sourceType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__sourceType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__sourceType_k__BackingField)) = value;
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x000D557C File Offset: 0x000D377C
		// (set) Token: 0x06003930 RID: 14640 RVA: 0x0002469B File Offset: 0x0002289B
		public unsafe int _buttonIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__buttonIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__buttonIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x04002228 RID: 8744
		private static readonly IntPtr NativeFieldInfoPtr__playerId_k__BackingField;

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeFieldInfoPtr__inputSourceIndex_k__BackingField;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeFieldInfoPtr__mouseSource_k__BackingField;

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeFieldInfoPtr__touchSource_k__BackingField;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeFieldInfoPtr__sourceType_k__BackingField;

		// Token: 0x0400222D RID: 8749
		private static readonly IntPtr NativeFieldInfoPtr__buttonIndex_k__BackingField;

		// Token: 0x0400222E RID: 8750
		private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_get_Int32_0;

		// Token: 0x0400222F RID: 8751
		private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0;

		// Token: 0x04002230 RID: 8752
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0;

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0;

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0;

		// Token: 0x04002235 RID: 8757
		private static readonly IntPtr NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0;

		// Token: 0x04002236 RID: 8758
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0;

		// Token: 0x04002237 RID: 8759
		private static readonly IntPtr NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0;

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0;

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0;

		// Token: 0x0400223A RID: 8762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;

		// Token: 0x0400223B RID: 8763
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
