using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000105 RID: 261
	public class KeySequence : Object
	{
		// Token: 0x060015B7 RID: 5559 RVA: 0x0006FAE8 File Offset: 0x0006DCE8
		// Note: this type is marked as 'beforefieldinit'.
		static KeySequence()
		{
			Il2CppClassPointerStore<KeySequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "KeySequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeySequence>.NativeClassPtr);
			KeySequence.NativeFieldInfoPtr_ks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, "ks");
			KeySequence.NativeFieldInfoPtr_dim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, "dim");
			KeySequence.NativeFieldInfoPtr_hashcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, "hashcode");
			KeySequence.NativeFieldInfoPtr_posline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, "posline");
			KeySequence.NativeFieldInfoPtr_poscol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, "poscol");
			KeySequence.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100666584);
			KeySequence.NativeMethodInfoPtr_get_PosLine_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100666585);
			KeySequence.NativeMethodInfoPtr_get_PosCol_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100666586);
			KeySequence.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100666587);
			KeySequence.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100666588);
			KeySequence.NativeMethodInfoPtr_IsQualified_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100666589);
			KeySequence.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100666590);
			KeySequence.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100666591);
			KeySequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100666592);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x0006FC30 File Offset: 0x0006DE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409141, XrefRangeEnd = 409144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeySequence(int dim, int line, int col)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeySequence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dim;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x0006FC94 File Offset: 0x0006DE94
		public unsafe int PosLine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr_get_PosLine_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x0006FCD0 File Offset: 0x0006DED0
		public unsafe int PosCol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr_get_PosCol_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000751 RID: 1873
		public unsafe Object this[int index]
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 18831, RefRangeEnd = 18841, XrefRangeStart = 18831, XrefRangeEnd = 18841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 409148, RefRangeEnd = 409153, XrefRangeStart = 409144, XrefRangeEnd = 409148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0006FDA8 File Offset: 0x0006DFA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 409154, RefRangeEnd = 409160, XrefRangeStart = 409153, XrefRangeEnd = 409154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsQualified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr_IsQualified_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0006FDE4 File Offset: 0x0006DFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409160, XrefRangeEnd = 409179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeySequence.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x0006FE2C File Offset: 0x0006E02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409179, XrefRangeEnd = 409184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeySequence.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0006FE84 File Offset: 0x0006E084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409184, XrefRangeEnd = 409202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeySequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00009B64 File Offset: 0x00007D64
		public KeySequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x0006FEC8 File Offset: 0x0006E0C8
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x00009B6D File Offset: 0x00007D6D
		public unsafe Il2CppReferenceArray<TypedObject> ks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_ks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TypedObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_ks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x0006FEF8 File Offset: 0x0006E0F8
		// (set) Token: 0x060015C5 RID: 5573 RVA: 0x00009B8C File Offset: 0x00007D8C
		public unsafe int dim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_dim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_dim)) = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x0006FF20 File Offset: 0x0006E120
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x00009BA7 File Offset: 0x00007DA7
		public unsafe int hashcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_hashcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_hashcode)) = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x0006FF48 File Offset: 0x0006E148
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x00009BC2 File Offset: 0x00007DC2
		public unsafe int posline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_posline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_posline)) = value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x0006FF70 File Offset: 0x0006E170
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x00009BDD File Offset: 0x00007DDD
		public unsafe int poscol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_poscol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_poscol)) = value;
			}
		}

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeFieldInfoPtr_ks;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeFieldInfoPtr_dim;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeFieldInfoPtr_hashcode;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeFieldInfoPtr_posline;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeFieldInfoPtr_poscol;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_get_PosLine_Public_get_Int32_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_get_PosCol_Public_get_Int32_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Object_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_IsQualified_Internal_Boolean_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
