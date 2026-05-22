using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Analytics
{
	// Token: 0x0200000C RID: 12
	public class CustomEventData
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x000045DC File Offset: 0x000027DC
		public ~CustomEventData()
		{
			this.Destroy();
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002711 File Offset: 0x00000911
		public void Destroy()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000271E File Offset: 0x0000091E
		public void Dispose()
		{
			this.Destroy();
			GC.SuppressFinalize(this);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000272F File Offset: 0x0000092F
		public static IntPtr Internal_Create(CustomEventData ced, string name)
		{
			return CustomEventData.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ced), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002747 File Offset: 0x00000947
		public static void Internal_Destroy(IntPtr ptr)
		{
			CustomEventData.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002754 File Offset: 0x00000954
		public bool AddString(string key, string value)
		{
			return CustomEventData.AddStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002772 File Offset: 0x00000972
		public bool AddInt32(string key, int value)
		{
			return CustomEventData.AddInt32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000278B File Offset: 0x0000098B
		public bool AddUInt32(string key, uint value)
		{
			return CustomEventData.AddUInt32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000027A4 File Offset: 0x000009A4
		public bool AddInt64(string key, long value)
		{
			return CustomEventData.AddInt64DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000027BD File Offset: 0x000009BD
		public bool AddUInt64(string key, ulong value)
		{
			return CustomEventData.AddUInt64DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000027D6 File Offset: 0x000009D6
		public bool AddBool(string key, bool value)
		{
			return CustomEventData.AddBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000027EF File Offset: 0x000009EF
		public bool AddDouble(string key, double value)
		{
			return CustomEventData.AddDoubleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000460C File Offset: 0x0000280C
		public bool AddDictionary(IDictionary<string, Object> eventData)
		{
			foreach (KeyValuePair<string, Object> keyValuePair in eventData)
			{
				string key = keyValuePair.Key;
				Object value = keyValuePair.Value;
				bool flag = value == null;
				if (flag)
				{
					this.AddString(key, "null");
				}
				else
				{
					Type type = value.GetType();
					bool flag2 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<string>());
					if (flag2)
					{
						this.AddString(key, value.Cast<string>());
					}
					else
					{
						bool flag3 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<char>());
						if (flag3)
						{
							this.AddString(key, Char.ToString((char)value));
						}
						else
						{
							bool flag4 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<sbyte>());
							if (flag4)
							{
								this.AddInt32(key, (int)((sbyte)value));
							}
							else
							{
								bool flag5 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<byte>());
								if (flag5)
								{
									this.AddInt32(key, (int)((byte)value));
								}
								else
								{
									bool flag6 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<short>());
									if (flag6)
									{
										this.AddInt32(key, (int)((short)value));
									}
									else
									{
										bool flag7 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ushort>());
										if (flag7)
										{
											this.AddUInt32(key, (uint)((ushort)value));
										}
										else
										{
											bool flag8 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
											if (flag8)
											{
												this.AddInt32(key, (int)value);
											}
											else
											{
												bool flag9 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<uint>());
												if (flag9)
												{
													this.AddUInt32(keyValuePair.Key, (uint)value);
												}
												else
												{
													bool flag10 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<long>());
													if (flag10)
													{
														this.AddInt64(key, (long)value);
													}
													else
													{
														bool flag11 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ulong>());
														if (flag11)
														{
															this.AddUInt64(key, (ulong)value);
														}
														else
														{
															bool flag12 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>());
															if (flag12)
															{
																this.AddBool(key, (bool)value);
															}
															else
															{
																bool flag13 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
																if (flag13)
																{
																	this.AddDouble(key, (double)Convert.ToDecimal((float)value));
																}
																else
																{
																	bool flag14 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<double>());
																	if (flag14)
																	{
																		this.AddDouble(key, (double)value);
																	}
																	else
																	{
																		bool flag15 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Decimal>());
																		if (flag15)
																		{
																			this.AddDouble(key, (double)Convert.ToDecimal((Decimal)value));
																		}
																		else
																		{
																			bool isValueType = type.IsValueType;
																			if (!isValueType)
																			{
																				throw new ArgumentException(String.Format("Invalid type: {0} passed", type));
																			}
																			this.AddString(key, value.ToString());
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0400008C RID: 140
		private static readonly CustomEventData.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<CustomEventData.Internal_CreateDelegate>("UnityEngine.Analytics.CustomEventData::Internal_Create");

		// Token: 0x0400008D RID: 141
		private static readonly CustomEventData.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<CustomEventData.Internal_DestroyDelegate>("UnityEngine.Analytics.CustomEventData::Internal_Destroy");

		// Token: 0x0400008E RID: 142
		private static readonly CustomEventData.AddStringDelegate AddStringDelegateField = IL2CPP.ResolveICall<CustomEventData.AddStringDelegate>("UnityEngine.Analytics.CustomEventData::AddString");

		// Token: 0x0400008F RID: 143
		private static readonly CustomEventData.AddInt32Delegate AddInt32DelegateField = IL2CPP.ResolveICall<CustomEventData.AddInt32Delegate>("UnityEngine.Analytics.CustomEventData::AddInt32");

		// Token: 0x04000090 RID: 144
		private static readonly CustomEventData.AddUInt32Delegate AddUInt32DelegateField = IL2CPP.ResolveICall<CustomEventData.AddUInt32Delegate>("UnityEngine.Analytics.CustomEventData::AddUInt32");

		// Token: 0x04000091 RID: 145
		private static readonly CustomEventData.AddInt64Delegate AddInt64DelegateField = IL2CPP.ResolveICall<CustomEventData.AddInt64Delegate>("UnityEngine.Analytics.CustomEventData::AddInt64");

		// Token: 0x04000092 RID: 146
		private static readonly CustomEventData.AddUInt64Delegate AddUInt64DelegateField = IL2CPP.ResolveICall<CustomEventData.AddUInt64Delegate>("UnityEngine.Analytics.CustomEventData::AddUInt64");

		// Token: 0x04000093 RID: 147
		private static readonly CustomEventData.AddBoolDelegate AddBoolDelegateField = IL2CPP.ResolveICall<CustomEventData.AddBoolDelegate>("UnityEngine.Analytics.CustomEventData::AddBool");

		// Token: 0x04000094 RID: 148
		private static readonly CustomEventData.AddDoubleDelegate AddDoubleDelegateField = IL2CPP.ResolveICall<CustomEventData.AddDoubleDelegate>("UnityEngine.Analytics.CustomEventData::AddDouble");

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060001AF RID: 431
		private delegate IntPtr Internal_CreateDelegate(IntPtr ced, IntPtr name);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060001B1 RID: 433
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060001B3 RID: 435
		private delegate bool AddStringDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060001B5 RID: 437
		private delegate bool AddInt32Delegate(IntPtr @this, IntPtr key, int value);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060001B7 RID: 439
		private delegate bool AddUInt32Delegate(IntPtr @this, IntPtr key, uint value);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060001B9 RID: 441
		private delegate bool AddInt64Delegate(IntPtr @this, IntPtr key, long value);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060001BB RID: 443
		private delegate bool AddUInt64Delegate(IntPtr @this, IntPtr key, ulong value);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060001BD RID: 445
		private delegate bool AddBoolDelegate(IntPtr @this, IntPtr key, bool value);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060001BF RID: 447
		private delegate bool AddDoubleDelegate(IntPtr @this, IntPtr key, double value);
	}
}
