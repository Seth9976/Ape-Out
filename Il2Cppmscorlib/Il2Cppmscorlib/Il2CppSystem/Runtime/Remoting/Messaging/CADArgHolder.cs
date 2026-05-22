using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E6 RID: 998
	public class CADArgHolder : Object
	{
		// Token: 0x06004058 RID: 16472 RVA: 0x0012D238 File Offset: 0x0012B438
		// Note: this type is marked as 'beforefieldinit'.
		static CADArgHolder()
		{
			Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADArgHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr);
			CADArgHolder.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr, "index");
			CADArgHolder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr, 100672764);
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x0012D290 File Offset: 0x0012B490
		[CallerCount(0)]
		public unsafe CADArgHolder(int i)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADArgHolder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x000182B6 File Offset: 0x000164B6
		public CADArgHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x0600405B RID: 16475 RVA: 0x0012D2D8 File Offset: 0x0012B4D8
		// (set) Token: 0x0600405C RID: 16476 RVA: 0x000182BF File Offset: 0x000164BF
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADArgHolder.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADArgHolder.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x040034CC RID: 13516
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x040034CD RID: 13517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
