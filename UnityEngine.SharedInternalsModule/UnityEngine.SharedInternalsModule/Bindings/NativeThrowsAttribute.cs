using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000019 RID: 25
	public class NativeThrowsAttribute : Attribute
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00004260 File Offset: 0x00002460
		// Note: this type is marked as 'beforefieldinit'.
		static NativeThrowsAttribute()
		{
			Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeThrowsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr);
			NativeThrowsAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr, "<ThrowsException>k__BackingField");
			NativeThrowsAttribute.NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr, 100663351);
			NativeThrowsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr, 100663352);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002632 File Offset: 0x00000832
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000042CC File Offset: 0x000024CC
		public unsafe virtual bool ThrowsException
		{
			get
			{
				return this._ThrowsException_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeThrowsAttribute.NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000430C File Offset: 0x0000250C
		[CallerCount(0)]
		public unsafe NativeThrowsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeThrowsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000260E File Offset: 0x0000080E
		public NativeThrowsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00004348 File Offset: 0x00002548
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002617 File Offset: 0x00000817
		public unsafe bool _ThrowsException_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeThrowsAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeThrowsAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField)) = value;
			}
		}

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr__ThrowsException_k__BackingField;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
