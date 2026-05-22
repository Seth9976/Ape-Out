using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000183 RID: 387
	public sealed class ValidationState : Object
	{
		// Token: 0x06001EE5 RID: 7909 RVA: 0x00093564 File Offset: 0x00091764
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationState()
		{
			Il2CppClassPointerStore<ValidationState>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ValidationState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationState>.NativeClassPtr);
			ValidationState.NativeFieldInfoPtr_IsNill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "IsNill");
			ValidationState.NativeFieldInfoPtr_IsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "IsDefault");
			ValidationState.NativeFieldInfoPtr_NeedValidateChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "NeedValidateChildren");
			ValidationState.NativeFieldInfoPtr_CheckRequiredAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "CheckRequiredAttribute");
			ValidationState.NativeFieldInfoPtr_ValidationSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ValidationSkipped");
			ValidationState.NativeFieldInfoPtr_ProcessContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ProcessContents");
			ValidationState.NativeFieldInfoPtr_Validity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "Validity");
			ValidationState.NativeFieldInfoPtr_ElementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ElementDecl");
			ValidationState.NativeFieldInfoPtr_ElementDeclBeforeXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ElementDeclBeforeXsi");
			ValidationState.NativeFieldInfoPtr_LocalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "LocalName");
			ValidationState.NativeFieldInfoPtr_Namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "Namespace");
			ValidationState.NativeFieldInfoPtr_Constr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "Constr");
			ValidationState.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "CurrentState");
			ValidationState.NativeFieldInfoPtr_HasMatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "HasMatched");
			ValidationState.NativeFieldInfoPtr_CurPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "CurPos");
			ValidationState.NativeFieldInfoPtr_AllElementsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "AllElementsSet");
			ValidationState.NativeFieldInfoPtr_RunningPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "RunningPositions");
			ValidationState.NativeFieldInfoPtr_TooComplex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "TooComplex");
			ValidationState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, 100667713);
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00093710 File Offset: 0x00091910
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 424705, RefRangeEnd = 424709, XrefRangeStart = 424702, XrefRangeEnd = 424705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x0000D75A File Offset: 0x0000B95A
		public ValidationState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x0009374C File Offset: 0x0009194C
		// (set) Token: 0x06001EE9 RID: 7913 RVA: 0x0000D763 File Offset: 0x0000B963
		public unsafe bool IsNill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_IsNill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_IsNill)) = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x00093774 File Offset: 0x00091974
		// (set) Token: 0x06001EEB RID: 7915 RVA: 0x0000D77E File Offset: 0x0000B97E
		public unsafe bool IsDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_IsDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_IsDefault)) = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001EEC RID: 7916 RVA: 0x0009379C File Offset: 0x0009199C
		// (set) Token: 0x06001EED RID: 7917 RVA: 0x0000D799 File Offset: 0x0000B999
		public unsafe bool NeedValidateChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_NeedValidateChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_NeedValidateChildren)) = value;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x000937C4 File Offset: 0x000919C4
		// (set) Token: 0x06001EEF RID: 7919 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
		public unsafe bool CheckRequiredAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CheckRequiredAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CheckRequiredAttribute)) = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x000937EC File Offset: 0x000919EC
		// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x0000D7CF File Offset: 0x0000B9CF
		public unsafe bool ValidationSkipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ValidationSkipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ValidationSkipped)) = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00093814 File Offset: 0x00091A14
		// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x0000D7EA File Offset: 0x0000B9EA
		public unsafe XmlSchemaContentProcessing ProcessContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ProcessContents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ProcessContents)) = value;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x0009383C File Offset: 0x00091A3C
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x0000D805 File Offset: 0x0000BA05
		public unsafe XmlSchemaValidity Validity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Validity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Validity)) = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x00093864 File Offset: 0x00091A64
		// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x0000D820 File Offset: 0x0000BA20
		public unsafe SchemaElementDecl ElementDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ElementDecl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ElementDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x00093894 File Offset: 0x00091A94
		// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x0000D83F File Offset: 0x0000BA3F
		public unsafe SchemaElementDecl ElementDeclBeforeXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ElementDeclBeforeXsi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ElementDeclBeforeXsi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x000938C4 File Offset: 0x00091AC4
		// (set) Token: 0x06001EFB RID: 7931 RVA: 0x0000D85E File Offset: 0x0000BA5E
		public unsafe string LocalName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_LocalName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_LocalName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x000938EC File Offset: 0x00091AEC
		// (set) Token: 0x06001EFD RID: 7933 RVA: 0x0000D87D File Offset: 0x0000BA7D
		public unsafe string Namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x00093914 File Offset: 0x00091B14
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x0000D89C File Offset: 0x0000BA9C
		public unsafe Il2CppReferenceArray<ConstraintStruct> Constr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Constr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstraintStruct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Constr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x00093944 File Offset: 0x00091B44
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x0000D8BB File Offset: 0x0000BABB
		public unsafe StateUnion CurrentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CurrentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CurrentState)) = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x0009396C File Offset: 0x00091B6C
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x0000D8D6 File Offset: 0x0000BAD6
		public unsafe bool HasMatched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_HasMatched);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_HasMatched)) = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x00093994 File Offset: 0x00091B94
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x0000D8F1 File Offset: 0x0000BAF1
		public unsafe Il2CppReferenceArray<BitSet> CurPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CurPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BitSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CurPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x000939C4 File Offset: 0x00091BC4
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x0000D910 File Offset: 0x0000BB10
		public unsafe BitSet AllElementsSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_AllElementsSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_AllElementsSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x000939F4 File Offset: 0x00091BF4
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x0000D92F File Offset: 0x0000BB2F
		public unsafe List<RangePositionInfo> RunningPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_RunningPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RangePositionInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_RunningPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x00093A24 File Offset: 0x00091C24
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x0000D94E File Offset: 0x0000BB4E
		public unsafe bool TooComplex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_TooComplex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_TooComplex)) = value;
			}
		}

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeFieldInfoPtr_IsNill;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr_IsDefault;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeFieldInfoPtr_NeedValidateChildren;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeFieldInfoPtr_CheckRequiredAttribute;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeFieldInfoPtr_ValidationSkipped;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeFieldInfoPtr_ProcessContents;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeFieldInfoPtr_Validity;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeFieldInfoPtr_ElementDecl;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeFieldInfoPtr_ElementDeclBeforeXsi;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeFieldInfoPtr_LocalName;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeFieldInfoPtr_Namespace;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeFieldInfoPtr_Constr;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeFieldInfoPtr_CurrentState;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeFieldInfoPtr_HasMatched;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeFieldInfoPtr_CurPos;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeFieldInfoPtr_AllElementsSet;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr_RunningPositions;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr_TooComplex;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
