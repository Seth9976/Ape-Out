using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000182 RID: 386
	[StructLayout(2)]
	public struct StateUnion
	{
		// Token: 0x06001EE3 RID: 7907 RVA: 0x000934E4 File Offset: 0x000916E4
		// Note: this type is marked as 'beforefieldinit'.
		static StateUnion()
		{
			Il2CppClassPointerStore<StateUnion>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "StateUnion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateUnion>.NativeClassPtr);
			StateUnion.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "State");
			StateUnion.NativeFieldInfoPtr_AllElementsRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "AllElementsRequired");
			StateUnion.NativeFieldInfoPtr_CurPosIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "CurPosIndex");
			StateUnion.NativeFieldInfoPtr_NumberOfRunningPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "NumberOfRunningPos");
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x0000D748 File Offset: 0x0000B948
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, ref this));
		}

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeFieldInfoPtr_AllElementsRequired;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeFieldInfoPtr_CurPosIndex;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeFieldInfoPtr_NumberOfRunningPos;

		// Token: 0x040016F4 RID: 5876
		[FieldOffset(0)]
		public int State;

		// Token: 0x040016F5 RID: 5877
		[FieldOffset(0)]
		public int AllElementsRequired;

		// Token: 0x040016F6 RID: 5878
		[FieldOffset(0)]
		public int CurPosIndex;

		// Token: 0x040016F7 RID: 5879
		[FieldOffset(0)]
		public int NumberOfRunningPos;
	}
}
