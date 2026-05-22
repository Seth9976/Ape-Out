using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000050 RID: 80
	[Serializable]
	public sealed class ExposedReference<T> : ValueType where T : Object
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x0001FC78 File Offset: 0x0001DE78
		// Note: this type is marked as 'beforefieldinit'.
		static ExposedReference()
		{
			Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExposedReference`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr);
			ExposedReference<T>.NativeFieldInfoPtr_exposedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, "exposedName");
			ExposedReference<T>.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, "defaultValue");
			ExposedReference<T>.NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, 100663622);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0001FD20 File Offset: 0x0001DF20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 487242, RefRangeEnd = 487243, XrefRangeStart = 487225, XrefRangeEnd = 487242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Resolve(IExposedPropertyTable resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExposedReference<T>.NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00004679 File Offset: 0x00002879
		public ExposedReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00004682 File Offset: 0x00002882
		public ExposedReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001FD70 File Offset: 0x0001DF70
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00004694 File Offset: 0x00002894
		public unsafe PropertyName exposedName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_exposedName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_exposedName)) = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0001FD98 File Offset: 0x0001DF98
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x000046AF File Offset: 0x000028AF
		public unsafe Object defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_defaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr_exposedName;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0;
	}
}
