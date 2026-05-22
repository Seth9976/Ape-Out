using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x020001EF RID: 495
	public sealed class LocalBuilder : LocalVariableInfo
	{
		// Token: 0x0600200A RID: 8202 RVA: 0x000B4FA0 File Offset: 0x000B31A0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalBuilder()
		{
			Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "LocalBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr);
			LocalBuilder.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "name");
			LocalBuilder.NativeFieldInfoPtr_ilgen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "ilgen");
			LocalBuilder.NativeFieldInfoPtr_startOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "startOffset");
			LocalBuilder.NativeFieldInfoPtr_endOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "endOffset");
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0000ABB7 File Offset: 0x00008DB7
		public LocalBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x000B5020 File Offset: 0x000B3220
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x000B5048 File Offset: 0x000B3248
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x0000ABDF File Offset: 0x00008DDF
		public unsafe ILGenerator ilgen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_ilgen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_ilgen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x000B5078 File Offset: 0x000B3278
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x0000ABFE File Offset: 0x00008DFE
		public unsafe int startOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_startOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_startOffset)) = value;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x000B50A0 File Offset: 0x000B32A0
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x0000AC19 File Offset: 0x00008E19
		public unsafe int endOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_endOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_endOffset)) = value;
			}
		}

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeFieldInfoPtr_ilgen;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeFieldInfoPtr_startOffset;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeFieldInfoPtr_endOffset;
	}
}
