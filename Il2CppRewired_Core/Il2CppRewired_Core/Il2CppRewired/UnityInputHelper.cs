using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200012C RID: 300
	public static class UnityInputHelper : Object
	{
		// Token: 0x06001F0F RID: 7951 RVA: 0x000A26D4 File Offset: 0x000A08D4
		// Note: this type is marked as 'beforefieldinit'.
		static UnityInputHelper()
		{
			Il2CppClassPointerStore<UnityInputHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "UnityInputHelper");
			UnityInputHelper.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputHelper>.NativeClassPtr, "fHwvAEhSaXstIllfGXDtviCPUrg");
			UnityInputHelper.NativeMethodInfoPtr_GetJoystickAxisValueByJoystickId_Public_Static_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputHelper>.NativeClassPtr, 100670035);
			UnityInputHelper.NativeMethodInfoPtr_GetJoystickAxisRawValueByJoystickId_Public_Static_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputHelper>.NativeClassPtr, 100670036);
			UnityInputHelper.NativeMethodInfoPtr_GetJoystickAxisValueByJoystickIndex_Public_Static_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputHelper>.NativeClassPtr, 100670037);
			UnityInputHelper.NativeMethodInfoPtr_GetJoystickAxisRawValueByJoystickIndex_Public_Static_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputHelper>.NativeClassPtr, 100670038);
			UnityInputHelper.NativeMethodInfoPtr_GetJoystickButtonValueByJoystickId_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputHelper>.NativeClassPtr, 100670039);
			UnityInputHelper.NativeMethodInfoPtr_GetJoystickButtonValueByJoystickIndex_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputHelper>.NativeClassPtr, 100670040);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x000A2788 File Offset: 0x000A0988
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 282195, RefRangeEnd = 282236, XrefRangeStart = 282190, XrefRangeEnd = 282195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetJoystickAxisValueByJoystickId(int joystickId, int axisIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputHelper.NativeMethodInfoPtr_GetJoystickAxisValueByJoystickId_Public_Static_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x000A27D4 File Offset: 0x000A09D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282236, XrefRangeEnd = 282241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetJoystickAxisRawValueByJoystickId(int joystickId, int axisIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputHelper.NativeMethodInfoPtr_GetJoystickAxisRawValueByJoystickId_Public_Static_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x000A2820 File Offset: 0x000A0A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282241, XrefRangeEnd = 282245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetJoystickAxisValueByJoystickIndex(int joystickIndex, int axisIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputHelper.NativeMethodInfoPtr_GetJoystickAxisValueByJoystickIndex_Public_Static_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x000A286C File Offset: 0x000A0A6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282254, RefRangeEnd = 282257, XrefRangeStart = 282245, XrefRangeEnd = 282254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetJoystickAxisRawValueByJoystickIndex(int joystickIndex, int axisIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputHelper.NativeMethodInfoPtr_GetJoystickAxisRawValueByJoystickIndex_Public_Static_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x000A28B8 File Offset: 0x000A0AB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282259, RefRangeEnd = 282260, XrefRangeStart = 282257, XrefRangeEnd = 282259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetJoystickButtonValueByJoystickId(int joystickId, int buttonIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputHelper.NativeMethodInfoPtr_GetJoystickButtonValueByJoystickId_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x000A2904 File Offset: 0x000A0B04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282265, RefRangeEnd = 282268, XrefRangeStart = 282260, XrefRangeEnd = 282265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetJoystickButtonValueByJoystickIndex(int joystickIndex, int buttonIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputHelper.NativeMethodInfoPtr_GetJoystickButtonValueByJoystickIndex_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x0000CB6F File Offset: 0x0000AD6F
		public UnityInputHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x000A2950 File Offset: 0x000A0B50
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x0000CB78 File Offset: 0x0000AD78
		public unsafe static Il2CppReferenceArray<UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj> fHwvAEhSaXstIllfGXDtviCPUrg
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityInputHelper.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityInputHelper.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickAxisValueByJoystickId_Public_Static_Single_Int32_Int32_0;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickAxisRawValueByJoystickId_Public_Static_Single_Int32_Int32_0;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickAxisValueByJoystickIndex_Public_Static_Single_Int32_Int32_0;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickAxisRawValueByJoystickIndex_Public_Static_Single_Int32_Int32_0;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickButtonValueByJoystickId_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickButtonValueByJoystickIndex_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x02000348 RID: 840
		public class xcpwOWiJFyOaCWwirDNWIzGSTpj : Object
		{
			// Token: 0x06004623 RID: 17955 RVA: 0x001462EC File Offset: 0x001444EC
			// Note: this type is marked as 'beforefieldinit'.
			static xcpwOWiJFyOaCWwirDNWIzGSTpj()
			{
				Il2CppClassPointerStore<UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityInputHelper>.NativeClassPtr, "xcpwOWiJFyOaCWwirDNWIzGSTpj");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj>.NativeClassPtr);
				UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj.NativeFieldInfoPtr_oUhnwvGjSGTmmLdzKrbQObhPhPP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj>.NativeClassPtr, "oUhnwvGjSGTmmLdzKrbQObhPhPP");
				UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj.NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj>.NativeClassPtr, "terPkRSKSKnRaaNCrZiynGTPcEu");
				UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj>.NativeClassPtr, 100670041);
			}

			// Token: 0x06004624 RID: 17956 RVA: 0x00146354 File Offset: 0x00144554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282172, XrefRangeEnd = 282190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe xcpwOWiJFyOaCWwirDNWIzGSTpj(int joystickIndex)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref joystickIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004625 RID: 17957 RVA: 0x000194F6 File Offset: 0x000176F6
			public xcpwOWiJFyOaCWwirDNWIzGSTpj(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015D3 RID: 5587
			// (get) Token: 0x06004626 RID: 17958 RVA: 0x0014639C File Offset: 0x0014459C
			// (set) Token: 0x06004627 RID: 17959 RVA: 0x000194FF File Offset: 0x000176FF
			public unsafe Il2CppStringArray oUhnwvGjSGTmmLdzKrbQObhPhPP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj.NativeFieldInfoPtr_oUhnwvGjSGTmmLdzKrbQObhPhPP);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj.NativeFieldInfoPtr_oUhnwvGjSGTmmLdzKrbQObhPhPP), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D4 RID: 5588
			// (get) Token: 0x06004628 RID: 17960 RVA: 0x001463CC File Offset: 0x001445CC
			// (set) Token: 0x06004629 RID: 17961 RVA: 0x0001951E File Offset: 0x0001771E
			public unsafe Il2CppStringArray terPkRSKSKnRaaNCrZiynGTPcEu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj.NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputHelper.xcpwOWiJFyOaCWwirDNWIzGSTpj.NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003948 RID: 14664
			private static readonly IntPtr NativeFieldInfoPtr_oUhnwvGjSGTmmLdzKrbQObhPhPP;

			// Token: 0x04003949 RID: 14665
			private static readonly IntPtr NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu;

			// Token: 0x0400394A RID: 14666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
