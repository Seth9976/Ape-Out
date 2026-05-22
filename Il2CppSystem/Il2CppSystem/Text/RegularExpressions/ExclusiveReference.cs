using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200004E RID: 78
	public sealed class ExclusiveReference : Object
	{
		// Token: 0x060004A4 RID: 1188 RVA: 0x00022DF8 File Offset: 0x00020FF8
		// Note: this type is marked as 'beforefieldinit'.
		static ExclusiveReference()
		{
			Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "ExclusiveReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr);
			ExclusiveReference.NativeFieldInfoPtr__ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, "_ref");
			ExclusiveReference.NativeFieldInfoPtr__obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, "_obj");
			ExclusiveReference.NativeFieldInfoPtr__locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, "_locked");
			ExclusiveReference.NativeMethodInfoPtr_Get_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, 100664062);
			ExclusiveReference.NativeMethodInfoPtr_Release_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, 100664063);
			ExclusiveReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, 100664064);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00022EA0 File Offset: 0x000210A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369950, XrefRangeEnd = 369951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveReference.NativeMethodInfoPtr_Get_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00022EE0 File Offset: 0x000210E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369951, XrefRangeEnd = 369953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveReference.NativeMethodInfoPtr_Release_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00022F24 File Offset: 0x00021124
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExclusiveReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00003ACE File Offset: 0x00001CCE
		public ExclusiveReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00022F60 File Offset: 0x00021160
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00003AD7 File Offset: 0x00001CD7
		public unsafe RegexRunner _ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__ref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexRunner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__ref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00022F90 File Offset: 0x00021190
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00003AF6 File Offset: 0x00001CF6
		public unsafe Object _obj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__obj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__obj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00022FC0 File Offset: 0x000211C0
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00003B15 File Offset: 0x00001D15
		public unsafe int _locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__locked)) = value;
			}
		}

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeFieldInfoPtr__ref;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeFieldInfoPtr__obj;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeFieldInfoPtr__locked;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Object_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_Release_Internal_Void_Object_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
