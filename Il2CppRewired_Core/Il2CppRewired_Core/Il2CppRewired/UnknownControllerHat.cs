using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000021 RID: 33
	public class UnknownControllerHat : Object
	{
		// Token: 0x0600029F RID: 671 RVA: 0x0003786C File Offset: 0x00035A6C
		// Note: this type is marked as 'beforefieldinit'.
		static UnknownControllerHat()
		{
			Il2CppClassPointerStore<UnknownControllerHat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "UnknownControllerHat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnknownControllerHat>.NativeClassPtr);
			UnknownControllerHat.NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnknownControllerHat>.NativeClassPtr, "terPkRSKSKnRaaNCrZiynGTPcEu");
			UnknownControllerHat.NativeMethodInfoPtr__ctor_Public_Void_HatButtons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownControllerHat>.NativeClassPtr, 100663703);
			UnknownControllerHat.NativeMethodInfoPtr_ContainsButtonIndex_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownControllerHat>.NativeClassPtr, 100663704);
			UnknownControllerHat.NativeMethodInfoPtr_IsButtonIndexCardinal_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownControllerHat>.NativeClassPtr, 100663705);
			UnknownControllerHat.NativeMethodInfoPtr_GetButtons_Public_HatButtons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownControllerHat>.NativeClassPtr, 100663706);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00037900 File Offset: 0x00035B00
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownControllerHat(UnknownControllerHat.HatButtons buttons)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnknownControllerHat>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buttons);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownControllerHat.NativeMethodInfoPtr__ctor_Public_Void_HatButtons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0003794C File Offset: 0x00035B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243890, XrefRangeEnd = 243891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsButtonIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownControllerHat.NativeMethodInfoPtr_ContainsButtonIndex_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00037998 File Offset: 0x00035B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243891, XrefRangeEnd = 243892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsButtonIndexCardinal(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownControllerHat.NativeMethodInfoPtr_IsButtonIndexCardinal_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000379E4 File Offset: 0x00035BE4
		[CallerCount(0)]
		public unsafe UnknownControllerHat.HatButtons GetButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownControllerHat.NativeMethodInfoPtr_GetButtons_Public_HatButtons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnknownControllerHat.HatButtons>(intPtr3) : null;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002DA6 File Offset: 0x00000FA6
		public UnknownControllerHat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00037A24 File Offset: 0x00035C24
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00002DAF File Offset: 0x00000FAF
		public unsafe UnknownControllerHat.HatButtons terPkRSKSKnRaaNCrZiynGTPcEu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownControllerHat.NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnknownControllerHat.HatButtons>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownControllerHat.NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HatButtons_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_ContainsButtonIndex_Public_Boolean_Int32_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_IsButtonIndexCardinal_Public_Boolean_Int32_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_GetButtons_Public_HatButtons_0;

		// Token: 0x02000223 RID: 547
		public class HatButtons : Object
		{
			// Token: 0x0600378F RID: 14223 RVA: 0x00111D9C File Offset: 0x0010FF9C
			// Note: this type is marked as 'beforefieldinit'.
			static HatButtons()
			{
				Il2CppClassPointerStore<UnknownControllerHat.HatButtons>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnknownControllerHat>.NativeClassPtr, "HatButtons");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnknownControllerHat.HatButtons>.NativeClassPtr);
				UnknownControllerHat.HatButtons.NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnknownControllerHat.HatButtons>.NativeClassPtr, "terPkRSKSKnRaaNCrZiynGTPcEu");
				UnknownControllerHat.HatButtons.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownControllerHat.HatButtons>.NativeClassPtr, 100663707);
				UnknownControllerHat.HatButtons.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownControllerHat.HatButtons>.NativeClassPtr, 100663708);
				UnknownControllerHat.HatButtons.NativeMethodInfoPtr_GetNeighbors_Public_Void_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownControllerHat.HatButtons>.NativeClassPtr, 100663709);
				UnknownControllerHat.HatButtons.NativeMethodInfoPtr_IsCardinal_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownControllerHat.HatButtons>.NativeClassPtr, 100663710);
				UnknownControllerHat.HatButtons.NativeMethodInfoPtr_IsCorner_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownControllerHat.HatButtons>.NativeClassPtr, 100663711);
				UnknownControllerHat.HatButtons.NativeMethodInfoPtr_IndexOf_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownControllerHat.HatButtons>.NativeClassPtr, 100663712);
				UnknownControllerHat.HatButtons.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownControllerHat.HatButtons>.NativeClassPtr, 100663713);
			}

			// Token: 0x17001095 RID: 4245
			public unsafe int this[int index]
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownControllerHat.HatButtons.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}

			// Token: 0x06003791 RID: 14225 RVA: 0x00111EB4 File Offset: 0x001100B4
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HatButtons(Il2CppStructArray<int> buttons)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnknownControllerHat.HatButtons>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buttons);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownControllerHat.HatButtons.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003792 RID: 14226 RVA: 0x00111F00 File Offset: 0x00110100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243883, XrefRangeEnd = 243885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetNeighbors(int button, out int neighbor1, out int neighbor2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &neighbor1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &neighbor2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownControllerHat.HatButtons.NativeMethodInfoPtr_GetNeighbors_Public_Void_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003793 RID: 14227 RVA: 0x00111F5C File Offset: 0x0011015C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243885, XrefRangeEnd = 243886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsCardinal(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownControllerHat.HatButtons.NativeMethodInfoPtr_IsCardinal_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003794 RID: 14228 RVA: 0x00111FA8 File Offset: 0x001101A8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 243887, RefRangeEnd = 243888, XrefRangeStart = 243886, XrefRangeEnd = 243887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsCorner(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownControllerHat.HatButtons.NativeMethodInfoPtr_IsCorner_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003795 RID: 14229 RVA: 0x00111FF4 File Offset: 0x001101F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243888, XrefRangeEnd = 243889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int IndexOf(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownControllerHat.HatButtons.NativeMethodInfoPtr_IndexOf_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003796 RID: 14230 RVA: 0x00112040 File Offset: 0x00110240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243889, XrefRangeEnd = 243890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Contains(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownControllerHat.HatButtons.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003797 RID: 14231 RVA: 0x0001327C File Offset: 0x0001147C
			public HatButtons(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001094 RID: 4244
			// (get) Token: 0x06003798 RID: 14232 RVA: 0x0011208C File Offset: 0x0011028C
			// (set) Token: 0x06003799 RID: 14233 RVA: 0x00013285 File Offset: 0x00011485
			public unsafe Il2CppStructArray<int> terPkRSKSKnRaaNCrZiynGTPcEu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownControllerHat.HatButtons.NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownControllerHat.HatButtons.NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F08 RID: 12040
			private static readonly IntPtr NativeFieldInfoPtr_terPkRSKSKnRaaNCrZiynGTPcEu;

			// Token: 0x04002F09 RID: 12041
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0;

			// Token: 0x04002F0A RID: 12042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0;

			// Token: 0x04002F0B RID: 12043
			private static readonly IntPtr NativeMethodInfoPtr_GetNeighbors_Public_Void_Int32_byref_Int32_byref_Int32_0;

			// Token: 0x04002F0C RID: 12044
			private static readonly IntPtr NativeMethodInfoPtr_IsCardinal_Public_Boolean_Int32_0;

			// Token: 0x04002F0D RID: 12045
			private static readonly IntPtr NativeMethodInfoPtr_IsCorner_Public_Boolean_Int32_0;

			// Token: 0x04002F0E RID: 12046
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Int32_0;

			// Token: 0x04002F0F RID: 12047
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0;
		}
	}
}
