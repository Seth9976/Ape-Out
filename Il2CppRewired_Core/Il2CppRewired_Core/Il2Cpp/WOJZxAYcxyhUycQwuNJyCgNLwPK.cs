using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired;
using Il2CppRewired.Config;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000127 RID: 295
	public class WOJZxAYcxyhUycQwuNJyCgNLwPK : Object
	{
		// Token: 0x06001E63 RID: 7779 RVA: 0x0009F960 File Offset: 0x0009DB60
		// Note: this type is marked as 'beforefieldinit'.
		static WOJZxAYcxyhUycQwuNJyCgNLwPK()
		{
			Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "", "WOJZxAYcxyhUycQwuNJyCgNLwPK");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr);
			WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_ZMbTMhTNmFnqBSHshQdNvvkRjBc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr, "ZMbTMhTNmFnqBSHshQdNvvkRjBc");
			WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr, "QupTlkbJPCSxpgHQnsUQVuFrjWa");
			WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_YIvTEMBkssMkNlgXXmhdLKgSICB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr, "YIvTEMBkssMkNlgXXmhdLKgSICB");
			WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr, "EDWjCkozGqmyQyquicPQVDMTCVq");
			WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Keyboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr, 100669886);
			WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr, 100669887);
			WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeMethodInfoPtr_ZOzKZTTEchiyzAeKqBVYcdufvnA_Public_Void_KeyboardMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr, 100669888);
			WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeMethodInfoPtr_yDqSSAIGtfYhAPuolszoLqcLAVE_Public_Boolean_KeyboardKeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr, 100669889);
			WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeMethodInfoPtr_TKiWmFaLEMnOYDsHlExcIQMuvRv_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr, 100669890);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0009FA44 File Offset: 0x0009DC44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281495, RefRangeEnd = 281496, XrefRangeStart = 281465, XrefRangeEnd = 281495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WOJZxAYcxyhUycQwuNJyCgNLwPK(UpdateLoopSetting updateLoopSetting, Keyboard keyboard)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoopSetting;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyboard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Keyboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0009FAA0 File Offset: 0x0009DCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281496, XrefRangeEnd = 281500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void xozDTcGUrsCTUDmjINWIvPSceAOJ(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0009FAE0 File Offset: 0x0009DCE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281501, RefRangeEnd = 281502, XrefRangeStart = 281500, XrefRangeEnd = 281501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZOzKZTTEchiyzAeKqBVYcdufvnA(KeyboardMap A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeMethodInfoPtr_ZOzKZTTEchiyzAeKqBVYcdufvnA_Public_Void_KeyboardMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x0009FB24 File Offset: 0x0009DD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281502, XrefRangeEnd = 281504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool yDqSSAIGtfYhAPuolszoLqcLAVE(KeyboardKeyCode A_1, ModifierKeyFlags A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeMethodInfoPtr_yDqSSAIGtfYhAPuolszoLqcLAVE_Public_Boolean_KeyboardKeyCode_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x0009FB7C File Offset: 0x0009DD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281504, XrefRangeEnd = 281506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TKiWmFaLEMnOYDsHlExcIQMuvRv()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeMethodInfoPtr_TKiWmFaLEMnOYDsHlExcIQMuvRv_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x0000C88D File Offset: 0x0000AA8D
		public WOJZxAYcxyhUycQwuNJyCgNLwPK(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x0009FBB0 File Offset: 0x0009DDB0
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x0000C896 File Offset: 0x0000AA96
		public unsafe Il2CppReferenceArray<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio> ZMbTMhTNmFnqBSHshQdNvvkRjBc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_ZMbTMhTNmFnqBSHshQdNvvkRjBc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_ZMbTMhTNmFnqBSHshQdNvvkRjBc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x0009FBE0 File Offset: 0x0009DDE0
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0000C8B5 File Offset: 0x0000AAB5
		public unsafe UpdateLoopType QupTlkbJPCSxpgHQnsUQVuFrjWa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa)) = value;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x0009FC08 File Offset: 0x0009DE08
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		public unsafe Keyboard YIvTEMBkssMkNlgXXmhdLKgSICB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_YIvTEMBkssMkNlgXXmhdLKgSICB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Keyboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_YIvTEMBkssMkNlgXXmhdLKgSICB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x0009FC38 File Offset: 0x0009DE38
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x0000C8EF File Offset: 0x0000AAEF
		public unsafe WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio EDWjCkozGqmyQyquicPQVDMTCVq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeFieldInfoPtr_ZMbTMhTNmFnqBSHshQdNvvkRjBc;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeFieldInfoPtr_YIvTEMBkssMkNlgXXmhdLKgSICB;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Keyboard_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_UpdateLoopType_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr_ZOzKZTTEchiyzAeKqBVYcdufvnA_Public_Void_KeyboardMap_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr_yDqSSAIGtfYhAPuolszoLqcLAVE_Public_Boolean_KeyboardKeyCode_ModifierKeyFlags_0;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_TKiWmFaLEMnOYDsHlExcIQMuvRv_Public_Void_0;

		// Token: 0x0200033D RID: 829
		public class hifgZwiHnUCnEWbilysHTXXpeio : Object
		{
			// Token: 0x060045E1 RID: 17889 RVA: 0x00145520 File Offset: 0x00143720
			// Note: this type is marked as 'beforefieldinit'.
			static hifgZwiHnUCnEWbilysHTXXpeio()
			{
				Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK>.NativeClassPtr, "hifgZwiHnUCnEWbilysHTXXpeio");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr);
				WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_UCVRGACKSSDmlgjFrEblDtOtbpKJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr, "UCVRGACKSSDmlgjFrEblDtOtbpKJ");
				WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_PnxtyUcWgnYhwzZQnqbTgdaiyS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr, "PnxtyUcWgnYhwzZQnqbTgdaiyS");
				WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_OIuihOYoHkHkmcjNpcfbcQSeZudY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr, "OIuihOYoHkHkmcjNpcfbcQSeZudY");
				WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_YIvTEMBkssMkNlgXXmhdLKgSICB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr, "YIvTEMBkssMkNlgXXmhdLKgSICB");
				WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr__ctor_Public_Void_Keyboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr, 100669891);
				WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr, 100669892);
				WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr_gSjNPigxOxLSdzLCwPOzckeltid_Public_Void_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr, 100669893);
				WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr_yDqSSAIGtfYhAPuolszoLqcLAVE_Public_Boolean_KeyboardKeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr, 100669894);
				WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr_yDqSSAIGtfYhAPuolszoLqcLAVE_Private_Boolean_ExpandableArray_DataContainer_1_UtEvloiSsiquaUTGruQLCrKfnqF_KeyboardKeyCode_ModifierKeyFlags_Int32_znvHPlFnPMysjreEdboQijELPiym_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr, 100669895);
				WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr, 100669896);
			}

			// Token: 0x060045E2 RID: 17890 RVA: 0x00145614 File Offset: 0x00143814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281407, XrefRangeEnd = 281417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe hifgZwiHnUCnEWbilysHTXXpeio(Keyboard keyboard)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyboard);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr__ctor_Public_Void_Keyboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060045E3 RID: 17891 RVA: 0x00145660 File Offset: 0x00143860
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 281426, RefRangeEnd = 281428, XrefRangeStart = 281417, XrefRangeEnd = 281426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xozDTcGUrsCTUDmjINWIvPSceAOJ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045E4 RID: 17892 RVA: 0x00145694 File Offset: 0x00143894
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 281433, RefRangeEnd = 281434, XrefRangeStart = 281428, XrefRangeEnd = 281433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void gSjNPigxOxLSdzLCwPOzckeltid(ActionElementMap A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr_gSjNPigxOxLSdzLCwPOzckeltid_Public_Void_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060045E5 RID: 17893 RVA: 0x001456D8 File Offset: 0x001438D8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 281443, RefRangeEnd = 281446, XrefRangeStart = 281434, XrefRangeEnd = 281443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool yDqSSAIGtfYhAPuolszoLqcLAVE(KeyboardKeyCode A_1, ModifierKeyFlags A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr_yDqSSAIGtfYhAPuolszoLqcLAVE_Public_Boolean_KeyboardKeyCode_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060045E6 RID: 17894 RVA: 0x00145730 File Offset: 0x00143930
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 281455, RefRangeEnd = 281457, XrefRangeStart = 281446, XrefRangeEnd = 281455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool yDqSSAIGtfYhAPuolszoLqcLAVE(ExpandableArray_DataContainer<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF> A_1, KeyboardKeyCode A_2, ModifierKeyFlags A_3, int A_4, WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.znvHPlFnPMysjreEdboQijELPiym A_5)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_5;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr_yDqSSAIGtfYhAPuolszoLqcLAVE_Private_Boolean_ExpandableArray_DataContainer_1_UtEvloiSsiquaUTGruQLCrKfnqF_KeyboardKeyCode_ModifierKeyFlags_Int32_znvHPlFnPMysjreEdboQijELPiym_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060045E7 RID: 17895 RVA: 0x001457B8 File Offset: 0x001439B8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 281463, RefRangeEnd = 281465, XrefRangeStart = 281457, XrefRangeEnd = 281463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GMFpQqtyJcjzYToWCrZsZQAhPYh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045E8 RID: 17896 RVA: 0x00019385 File Offset: 0x00017585
			public hifgZwiHnUCnEWbilysHTXXpeio(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015CF RID: 5583
			// (get) Token: 0x060045E9 RID: 17897 RVA: 0x001457EC File Offset: 0x001439EC
			// (set) Token: 0x060045EA RID: 17898 RVA: 0x0001938E File Offset: 0x0001758E
			public unsafe ModifierKeyFlags UCVRGACKSSDmlgjFrEblDtOtbpKJ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_UCVRGACKSSDmlgjFrEblDtOtbpKJ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_UCVRGACKSSDmlgjFrEblDtOtbpKJ)) = value;
				}
			}

			// Token: 0x170015D0 RID: 5584
			// (get) Token: 0x060045EB RID: 17899 RVA: 0x00145814 File Offset: 0x00143A14
			// (set) Token: 0x060045EC RID: 17900 RVA: 0x000193A9 File Offset: 0x000175A9
			public unsafe ExpandableArray_DataContainer<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF> PnxtyUcWgnYhwzZQnqbTgdaiyS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_PnxtyUcWgnYhwzZQnqbTgdaiyS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandableArray_DataContainer<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_PnxtyUcWgnYhwzZQnqbTgdaiyS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D1 RID: 5585
			// (get) Token: 0x060045ED RID: 17901 RVA: 0x00145844 File Offset: 0x00143A44
			// (set) Token: 0x060045EE RID: 17902 RVA: 0x000193C8 File Offset: 0x000175C8
			public unsafe ExpandableArray_DataContainer<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF> OIuihOYoHkHkmcjNpcfbcQSeZudY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_OIuihOYoHkHkmcjNpcfbcQSeZudY);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandableArray_DataContainer<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_OIuihOYoHkHkmcjNpcfbcQSeZudY), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D2 RID: 5586
			// (get) Token: 0x060045EF RID: 17903 RVA: 0x00145874 File Offset: 0x00143A74
			// (set) Token: 0x060045F0 RID: 17904 RVA: 0x000193E7 File Offset: 0x000175E7
			public unsafe Keyboard YIvTEMBkssMkNlgXXmhdLKgSICB
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_YIvTEMBkssMkNlgXXmhdLKgSICB);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Keyboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.NativeFieldInfoPtr_YIvTEMBkssMkNlgXXmhdLKgSICB), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003925 RID: 14629
			private static readonly IntPtr NativeFieldInfoPtr_UCVRGACKSSDmlgjFrEblDtOtbpKJ;

			// Token: 0x04003926 RID: 14630
			private static readonly IntPtr NativeFieldInfoPtr_PnxtyUcWgnYhwzZQnqbTgdaiyS;

			// Token: 0x04003927 RID: 14631
			private static readonly IntPtr NativeFieldInfoPtr_OIuihOYoHkHkmcjNpcfbcQSeZudY;

			// Token: 0x04003928 RID: 14632
			private static readonly IntPtr NativeFieldInfoPtr_YIvTEMBkssMkNlgXXmhdLKgSICB;

			// Token: 0x04003929 RID: 14633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Keyboard_0;

			// Token: 0x0400392A RID: 14634
			private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0;

			// Token: 0x0400392B RID: 14635
			private static readonly IntPtr NativeMethodInfoPtr_gSjNPigxOxLSdzLCwPOzckeltid_Public_Void_ActionElementMap_0;

			// Token: 0x0400392C RID: 14636
			private static readonly IntPtr NativeMethodInfoPtr_yDqSSAIGtfYhAPuolszoLqcLAVE_Public_Boolean_KeyboardKeyCode_ModifierKeyFlags_0;

			// Token: 0x0400392D RID: 14637
			private static readonly IntPtr NativeMethodInfoPtr_yDqSSAIGtfYhAPuolszoLqcLAVE_Private_Boolean_ExpandableArray_DataContainer_1_UtEvloiSsiquaUTGruQLCrKfnqF_KeyboardKeyCode_ModifierKeyFlags_Int32_znvHPlFnPMysjreEdboQijELPiym_0;

			// Token: 0x0400392E RID: 14638
			private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0;

			// Token: 0x02000568 RID: 1384
			public class UtEvloiSsiquaUTGruQLCrKfnqF : Object
			{
				// Token: 0x06005BE0 RID: 23520 RVA: 0x001932EC File Offset: 0x001914EC
				// Note: this type is marked as 'beforefieldinit'.
				static UtEvloiSsiquaUTGruQLCrKfnqF()
				{
					Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio>.NativeClassPtr, "UtEvloiSsiquaUTGruQLCrKfnqF");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>.NativeClassPtr);
					WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeFieldInfoPtr_sZfOAbuViDxxWveYyIghfELthPGh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>.NativeClassPtr, "sZfOAbuViDxxWveYyIghfELthPGh");
					WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeFieldInfoPtr_vvDFwfgymFHLCWqZioiQRmgsAVB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>.NativeClassPtr, "vvDFwfgymFHLCWqZioiQRmgsAVB");
					WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Void_KeyboardKeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>.NativeClassPtr, 100669897);
					WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Virtual_Final_New_Void_UtEvloiSsiquaUTGruQLCrKfnqF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>.NativeClassPtr, 100669898);
					WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr_IrrqjlxJUgjJRmwPgXSuZpiUFbk_Public_Virtual_Final_New_Boolean_UtEvloiSsiquaUTGruQLCrKfnqF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>.NativeClassPtr, 100669899);
					WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>.NativeClassPtr, 100669900);
					WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UtEvloiSsiquaUTGruQLCrKfnqF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>.NativeClassPtr, 100669901);
					WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>.NativeClassPtr, 100669902);
				}

				// Token: 0x06005BE1 RID: 23521 RVA: 0x001933B8 File Offset: 0x001915B8
				[CallerCount(0)]
				public unsafe void MRZTryplKgDXZkLfSZwrsdDSOdq(KeyboardKeyCode A_1, ModifierKeyFlags A_2)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref A_1;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Void_KeyboardKeyCode_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005BE2 RID: 23522 RVA: 0x00193404 File Offset: 0x00191604
				[CallerCount(0)]
				public unsafe virtual void MRZTryplKgDXZkLfSZwrsdDSOdq(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Virtual_Final_New_Void_UtEvloiSsiquaUTGruQLCrKfnqF_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06005BE3 RID: 23523 RVA: 0x00193448 File Offset: 0x00191648
				[CallerCount(0)]
				public unsafe virtual bool IrrqjlxJUgjJRmwPgXSuZpiUFbk(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr_IrrqjlxJUgjJRmwPgXSuZpiUFbk_Public_Virtual_Final_New_Boolean_UtEvloiSsiquaUTGruQLCrKfnqF_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06005BE4 RID: 23524 RVA: 0x00193498 File Offset: 0x00191698
				[CallerCount(0)]
				public unsafe virtual void GMFpQqtyJcjzYToWCrZsZQAhPYh()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005BE5 RID: 23525 RVA: 0x001934CC File Offset: 0x001916CC
				[CallerCount(0)]
				public unsafe virtual int CompareTo(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF other)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UtEvloiSsiquaUTGruQLCrKfnqF_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06005BE6 RID: 23526 RVA: 0x0019351C File Offset: 0x0019171C
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UtEvloiSsiquaUTGruQLCrKfnqF()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005BE7 RID: 23527 RVA: 0x000228F3 File Offset: 0x00020AF3
				public UtEvloiSsiquaUTGruQLCrKfnqF(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001C7A RID: 7290
				// (get) Token: 0x06005BE8 RID: 23528 RVA: 0x00193558 File Offset: 0x00191758
				// (set) Token: 0x06005BE9 RID: 23529 RVA: 0x000228FC File Offset: 0x00020AFC
				public unsafe KeyboardKeyCode sZfOAbuViDxxWveYyIghfELthPGh
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeFieldInfoPtr_sZfOAbuViDxxWveYyIghfELthPGh);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeFieldInfoPtr_sZfOAbuViDxxWveYyIghfELthPGh)) = value;
					}
				}

				// Token: 0x17001C7B RID: 7291
				// (get) Token: 0x06005BEA RID: 23530 RVA: 0x00193580 File Offset: 0x00191780
				// (set) Token: 0x06005BEB RID: 23531 RVA: 0x00022917 File Offset: 0x00020B17
				public unsafe ModifierKeyFlags vvDFwfgymFHLCWqZioiQRmgsAVB
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeFieldInfoPtr_vvDFwfgymFHLCWqZioiQRmgsAVB);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WOJZxAYcxyhUycQwuNJyCgNLwPK.hifgZwiHnUCnEWbilysHTXXpeio.UtEvloiSsiquaUTGruQLCrKfnqF.NativeFieldInfoPtr_vvDFwfgymFHLCWqZioiQRmgsAVB)) = value;
					}
				}

				// Token: 0x04004B16 RID: 19222
				private static readonly IntPtr NativeFieldInfoPtr_sZfOAbuViDxxWveYyIghfELthPGh;

				// Token: 0x04004B17 RID: 19223
				private static readonly IntPtr NativeFieldInfoPtr_vvDFwfgymFHLCWqZioiQRmgsAVB;

				// Token: 0x04004B18 RID: 19224
				private static readonly IntPtr NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Void_KeyboardKeyCode_ModifierKeyFlags_0;

				// Token: 0x04004B19 RID: 19225
				private static readonly IntPtr NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Virtual_Final_New_Void_UtEvloiSsiquaUTGruQLCrKfnqF_0;

				// Token: 0x04004B1A RID: 19226
				private static readonly IntPtr NativeMethodInfoPtr_IrrqjlxJUgjJRmwPgXSuZpiUFbk_Public_Virtual_Final_New_Boolean_UtEvloiSsiquaUTGruQLCrKfnqF_0;

				// Token: 0x04004B1B RID: 19227
				private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Virtual_Final_New_Void_0;

				// Token: 0x04004B1C RID: 19228
				private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UtEvloiSsiquaUTGruQLCrKfnqF_0;

				// Token: 0x04004B1D RID: 19229
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}

			// Token: 0x02000569 RID: 1385
			[OriginalName("Rewired_Core.dll", "", "znvHPlFnPMysjreEdboQijELPiym")]
			public enum znvHPlFnPMysjreEdboQijELPiym
			{
				// Token: 0x04004B1F RID: 19231
				wBRunGsXOapbDhrIIgQoicIMIER,
				// Token: 0x04004B20 RID: 19232
				CPJNbqaeLGkXyeIkeNhDQCpamnS
			}
		}
	}
}
