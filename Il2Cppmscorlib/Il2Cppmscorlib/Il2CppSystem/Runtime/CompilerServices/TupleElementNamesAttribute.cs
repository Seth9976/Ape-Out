using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000414 RID: 1044
	public sealed class TupleElementNamesAttribute : Attribute
	{
		// Token: 0x06004288 RID: 17032 RVA: 0x001352AC File Offset: 0x001334AC
		// Note: this type is marked as 'beforefieldinit'.
		static TupleElementNamesAttribute()
		{
			Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TupleElementNamesAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr);
			TupleElementNamesAttribute.NativeFieldInfoPtr__transformNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr, "_transformNames");
			TupleElementNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr, 100673030);
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x00135304 File Offset: 0x00133504
		[CallerCount(0)]
		public unsafe TupleElementNamesAttribute(Il2CppStringArray transformNames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transformNames);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleElementNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x0001920A File Offset: 0x0001740A
		public TupleElementNamesAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x00135350 File Offset: 0x00133550
		// (set) Token: 0x0600428C RID: 17036 RVA: 0x00019213 File Offset: 0x00017413
		public unsafe Il2CppStringArray _transformNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleElementNamesAttribute.NativeFieldInfoPtr__transformNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleElementNamesAttribute.NativeFieldInfoPtr__transformNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003644 RID: 13892
		private static readonly IntPtr NativeFieldInfoPtr__transformNames;

		// Token: 0x04003645 RID: 13893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;
	}
}
