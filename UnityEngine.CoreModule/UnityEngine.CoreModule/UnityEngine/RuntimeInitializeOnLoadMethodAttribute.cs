using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000E0 RID: 224
	public class RuntimeInitializeOnLoadMethodAttribute : UnityEngine.Scripting.PreserveAttribute
	{
		// Token: 0x06001357 RID: 4951 RVA: 0x0004EA34 File Offset: 0x0004CC34
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeInitializeOnLoadMethodAttribute()
		{
			Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RuntimeInitializeOnLoadMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr);
			RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, "m_LoadType");
			RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100664971);
			RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100664972);
			RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100664973);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0004EAB4 File Offset: 0x0004CCB4
		[CallerCount(0)]
		public unsafe RuntimeInitializeOnLoadMethodAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0004EAF0 File Offset: 0x0004CCF0
		[CallerCount(0)]
		public unsafe RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loadType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x0004EBA0 File Offset: 0x0004CDA0
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x0004EB38 File Offset: 0x0004CD38
		public unsafe RuntimeInitializeLoadType loadType
		{
			get
			{
				return this.m_LoadType;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0000ADE0 File Offset: 0x00008FE0
		public RuntimeInitializeOnLoadMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0004EB78 File Offset: 0x0004CD78
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x0000ADE9 File Offset: 0x00008FE9
		public unsafe RuntimeInitializeLoadType m_LoadType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType)) = value;
			}
		}

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadType;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0;
	}
}
