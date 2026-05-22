using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public class SECTR_CueParam : global::Il2CppSystem.Object
	{
		// Token: 0x06000A36 RID: 2614 RVA: 0x0005251C File Offset: 0x0005071C
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_CueParam()
		{
			Il2CppClassPointerStore<SECTR_CueParam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_CueParam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_CueParam>.NativeClassPtr);
			SECTR_CueParam.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CueParam>.NativeClassPtr, "name");
			SECTR_CueParam.NativeFieldInfoPtr_affects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CueParam>.NativeClassPtr, "affects");
			SECTR_CueParam.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CueParam>.NativeClassPtr, "defaultValue");
			SECTR_CueParam.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CueParam>.NativeClassPtr, "curve");
			SECTR_CueParam.NativeFieldInfoPtr_attributeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CueParam>.NativeClassPtr, "attributeData");
			SECTR_CueParam.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CueParam>.NativeClassPtr, "toggle");
			SECTR_CueParam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CueParam>.NativeClassPtr, 100664137);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x000525D8 File Offset: 0x000507D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39847, XrefRangeEnd = 39857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_CueParam()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_CueParam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CueParam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00008721 File Offset: 0x00006921
		public SECTR_CueParam(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00052614 File Offset: 0x00050814
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0000872A File Offset: 0x0000692A
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0005263C File Offset: 0x0005083C
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00008749 File Offset: 0x00006949
		public unsafe SECTR_CueParam.TargetType affects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_affects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_affects)) = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00052664 File Offset: 0x00050864
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00008764 File Offset: 0x00006964
		public unsafe float defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_defaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_defaultValue)) = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0005268C File Offset: 0x0005088C
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0000877F File Offset: 0x0000697F
		public unsafe AnimationCurve curve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_curve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x000526BC File Offset: 0x000508BC
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x0000879E File Offset: 0x0000699E
		public unsafe SECTR_CueParam.AttributeData attributeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_attributeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_CueParam.AttributeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_attributeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x000526EC File Offset: 0x000508EC
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x000087BD File Offset: 0x000069BD
		public unsafe bool toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_toggle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.NativeFieldInfoPtr_toggle)) = value;
			}
		}

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeFieldInfoPtr_affects;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeFieldInfoPtr_curve;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeFieldInfoPtr_attributeData;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002B9 RID: 697
		[OriginalName("Assembly-CSharp.dll", "", "TargetType")]
		public enum TargetType
		{
			// Token: 0x04003184 RID: 12676
			Volume,
			// Token: 0x04003185 RID: 12677
			Pitch,
			// Token: 0x04003186 RID: 12678
			Attribute
		}

		// Token: 0x020002BA RID: 698
		[Serializable]
		public class AttributeData : global::Il2CppSystem.Object
		{
			// Token: 0x06004B82 RID: 19330 RVA: 0x00117318 File Offset: 0x00115518
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeData()
			{
				Il2CppClassPointerStore<SECTR_CueParam.AttributeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_CueParam>.NativeClassPtr, "AttributeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_CueParam.AttributeData>.NativeClassPtr);
				SECTR_CueParam.AttributeData.NativeFieldInfoPtr_componentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CueParam.AttributeData>.NativeClassPtr, "componentType");
				SECTR_CueParam.AttributeData.NativeFieldInfoPtr_componentTypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CueParam.AttributeData>.NativeClassPtr, "componentTypeString");
				SECTR_CueParam.AttributeData.NativeFieldInfoPtr_attributeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CueParam.AttributeData>.NativeClassPtr, "attributeName");
				SECTR_CueParam.AttributeData.NativeFieldInfoPtr_fieldAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CueParam.AttributeData>.NativeClassPtr, "fieldAttribute");
				SECTR_CueParam.AttributeData.NativeMethodInfoPtr_set_ComponentType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CueParam.AttributeData>.NativeClassPtr, 100664138);
				SECTR_CueParam.AttributeData.NativeMethodInfoPtr_get_ComponentType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CueParam.AttributeData>.NativeClassPtr, 100664139);
				SECTR_CueParam.AttributeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CueParam.AttributeData>.NativeClassPtr, 100664140);
			}

			// Token: 0x17001B81 RID: 7041
			// (get) Token: 0x06004B84 RID: 19332 RVA: 0x00117414 File Offset: 0x00115614
			// (set) Token: 0x06004B83 RID: 19331 RVA: 0x001173D0 File Offset: 0x001155D0
			public unsafe Type ComponentType
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39837, XrefRangeEnd = 39847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CueParam.AttributeData.NativeMethodInfoPtr_get_ComponentType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39834, XrefRangeEnd = 39837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CueParam.AttributeData.NativeMethodInfoPtr_set_ComponentType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004B85 RID: 19333 RVA: 0x00117454 File Offset: 0x00115654
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_CueParam.AttributeData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CueParam.AttributeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B86 RID: 19334 RVA: 0x0002C5EC File Offset: 0x0002A7EC
			public AttributeData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B7D RID: 7037
			// (get) Token: 0x06004B87 RID: 19335 RVA: 0x00117490 File Offset: 0x00115690
			// (set) Token: 0x06004B88 RID: 19336 RVA: 0x0002C5F5 File Offset: 0x0002A7F5
			public unsafe Type componentType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.AttributeData.NativeFieldInfoPtr_componentType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.AttributeData.NativeFieldInfoPtr_componentType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B7E RID: 7038
			// (get) Token: 0x06004B89 RID: 19337 RVA: 0x001174C0 File Offset: 0x001156C0
			// (set) Token: 0x06004B8A RID: 19338 RVA: 0x0002C614 File Offset: 0x0002A814
			public unsafe string componentTypeString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.AttributeData.NativeFieldInfoPtr_componentTypeString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.AttributeData.NativeFieldInfoPtr_componentTypeString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001B7F RID: 7039
			// (get) Token: 0x06004B8B RID: 19339 RVA: 0x001174E8 File Offset: 0x001156E8
			// (set) Token: 0x06004B8C RID: 19340 RVA: 0x0002C633 File Offset: 0x0002A833
			public unsafe string attributeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.AttributeData.NativeFieldInfoPtr_attributeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.AttributeData.NativeFieldInfoPtr_attributeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001B80 RID: 7040
			// (get) Token: 0x06004B8D RID: 19341 RVA: 0x00117510 File Offset: 0x00115710
			// (set) Token: 0x06004B8E RID: 19342 RVA: 0x0002C652 File Offset: 0x0002A852
			public unsafe bool fieldAttribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.AttributeData.NativeFieldInfoPtr_fieldAttribute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CueParam.AttributeData.NativeFieldInfoPtr_fieldAttribute)) = value;
				}
			}

			// Token: 0x04003187 RID: 12679
			private static readonly IntPtr NativeFieldInfoPtr_componentType;

			// Token: 0x04003188 RID: 12680
			private static readonly IntPtr NativeFieldInfoPtr_componentTypeString;

			// Token: 0x04003189 RID: 12681
			private static readonly IntPtr NativeFieldInfoPtr_attributeName;

			// Token: 0x0400318A RID: 12682
			private static readonly IntPtr NativeFieldInfoPtr_fieldAttribute;

			// Token: 0x0400318B RID: 12683
			private static readonly IntPtr NativeMethodInfoPtr_set_ComponentType_Public_set_Void_Type_0;

			// Token: 0x0400318C RID: 12684
			private static readonly IntPtr NativeMethodInfoPtr_get_ComponentType_Public_get_Type_0;

			// Token: 0x0400318D RID: 12685
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
