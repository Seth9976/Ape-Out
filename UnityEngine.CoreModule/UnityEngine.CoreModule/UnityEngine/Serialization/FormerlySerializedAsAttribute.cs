using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Serialization
{
	// Token: 0x02000137 RID: 311
	public class FormerlySerializedAsAttribute : Attribute
	{
		// Token: 0x060018B4 RID: 6324 RVA: 0x0005FE04 File Offset: 0x0005E004
		// Note: this type is marked as 'beforefieldinit'.
		static FormerlySerializedAsAttribute()
		{
			Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Serialization", "FormerlySerializedAsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr);
			FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, "m_oldName");
			FormerlySerializedAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, 100665588);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0005FE5C File Offset: 0x0005E05C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormerlySerializedAsAttribute(string oldName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormerlySerializedAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0000CFD7 File Offset: 0x0000B1D7
		public FormerlySerializedAsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0005FEA8 File Offset: 0x0005E0A8
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x0000CFE0 File Offset: 0x0000B1E0
		public unsafe string m_oldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0005FED0 File Offset: 0x0005E0D0
		public string oldName
		{
			get
			{
				return this.m_oldName;
			}
		}

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_m_oldName;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
